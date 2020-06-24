using Composite;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(UseType));
            TxtEquipos.ScrollBars = ScrollBars.Vertical;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double presupuesto = Convert.ToDouble(TxtPresupuesto.Text);
                UseType use = (UseType)Enum.Parse(typeof(UseType), comboBox1.SelectedValue.ToString());

                var armadoEquipo = new ArmadoEquipo(use, presupuesto);
                var equipos = armadoEquipo.GetEquipos();

                if (equipos.Count == 0)
                {
                    throw new Exception("no se encontraron equipos");
                }

                var infoElemento = new StringBuilder();
                int i = 1;
                foreach (var equipo in equipos)
                {
                    infoElemento.Append($"equipo " + i++ + "\r\n");
                    foreach (IParte<IPerfomance> element in equipo.GetElements())
                    {
                        infoElemento.Append($"-{GetNameComponent(element)}-   " +
                                            $"{element.Name}    ${element.Price}" + "\r\n");
                    }
                    infoElemento.Append($"  Total: ${equipo.GetTotalPrice()}" + "\r\n");
                    infoElemento.Append("\r\n");
                }
                TxtEquipos.Text = infoElemento.ToString();
            }
            catch (FormatException)
            {
                TxtEquipos.Text = string.Empty;
                MessageBox.Show("error en la carga de datos");
            }
            catch (Exception ex)
            {
                TxtEquipos.Text = string.Empty;
                MessageBox.Show(ex.Message);
            }

        }

        private static string GetNameComponent(IParte<IPerfomance> element)
        {
            return string.Concat(element.GetType().Name.Reverse().Skip(2).Reverse());
        }
    }
}
