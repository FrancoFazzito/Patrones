using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace Repositorio
{
    abstract class ServicioDatos<T> : IRepositorio<T> where T : IEntidad, new()
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder commandBuilder;

        public ServicioDatos()
        {
            dataAdapter = new SqlDataAdapter(GetSelect(), Conexion.SqlConexion);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
            dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
        }

        public abstract string GetSelect();

        public void Actualizar(T entidad)
        {
            var table = GetDataTableFill();
            var row = GetRow(entidad.Id, table); 
            row.ItemArray = GetValues(entidad);
            Save(table);
        }

        public void Agregar(T entidad)
        {
            List<T> items = GetAll();
            var table = ConvertListToTable.ToDataTable(items);
            var values = GetValues(entidad);
            table.Rows.Add(values);
            Save(table);

            
        }

        private object[] GetValues(T entidad)
        {
            return ConvertListToTable.GetObjectValues(entidad);
        }

        public List<T> Buscar(Func<T, bool> where)
        {
            return GetAll().Where(where).ToList();
        }

        public List<T> Ordenar(Func<T, object> order)
        {
            return GetAll().OrderBy(order).ToList();
        }

        public void Eliminar(int id)
        {
            var table = GetDataTableFill();
            var row = GetRow(id, table);
            row.Delete();
            Save(table);
        }

        private DataRow GetRow(int id, DataTable table)
        {
            return ConvertListToTable.GetDataRowId(id, table);
        }

        public List<T> GetAll()
        {
            var table = new DataTable(typeof(T).Name);
            dataAdapter.Fill(table);
            return ConvertTableToList.ConvertDataTable(table);
        }

        public T ObtenerPorId(int id)
        {
            return GetAll().Find(e => e.Id == id);
        }

        private DataTable GetDataTableFill()
        {
            var table = new DataTable(typeof(T).Name);
            dataAdapter.Fill(table);
            return table;
        }

        private void Save(DataTable table)
        {
            dataAdapter.Update(table);
        }

        private static class ConvertListToTable
        {
            public static object[] GetObjectValues(T item)
            {
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                return values;
            }

            public static DataTable ToDataTable(List<T> items)
            {
                DataTable dataTable = new DataTable(typeof(T).Name);
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }

                dataTable.AcceptChanges();

                return dataTable;
            }

            public static DataRow GetDataRowId(int id, DataTable table)
            {
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(id);
                return row;
            }
        }

        private static class ConvertTableToList
        {
            public static List<T> ConvertDataTable(DataTable dt)
            {
                List<T> data = new List<T>();
                foreach (DataRow row in dt.Rows)
                {
                    T item = GetItem(row);
                    data.Add(item);
                }
                return data;
            }

            private static T GetItem(DataRow dr)
            {
                Type temp = typeof(T);
                T obj = Activator.CreateInstance<T>();

                foreach (DataColumn column in dr.Table.Columns)
                {
                    foreach (PropertyInfo pro in temp.GetProperties())
                    {
                        if (pro.Name == column.ColumnName)
                            pro.SetValue(obj, dr[column.ColumnName], null);
                        else
                            continue;
                    }
                }
                return obj;
            }
        }
    }

}
