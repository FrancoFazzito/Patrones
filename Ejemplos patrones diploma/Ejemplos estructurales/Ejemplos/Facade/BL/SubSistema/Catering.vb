Public Class Catering

    Public Enum TipoCatering
        CocinaDeAutor
        Clasico
        MenuInfantil
        PizzaLibre
    End Enum

    Dim mCosto As Double
    Public ReadOnly Property Costo As Double
        Get
            Return mCosto
        End Get
    End Property

    Public Property MesaDulce As Boolean = True
    Public Property FinDeFiesta As Boolean = False
    Public Property Tipo As TipoCatering = TipoCatering.Clasico

    Public Function Contratar(pCantidad As Integer, pFecha As DateTime) As String
        Dim mCubierto As Single
        Dim mRes As String

        mRes = "Menú: " & ControlChars.CrLf
        Select Case Tipo
            Case TipoCatering.Clasico
                mCubierto = 500
                mRes &= ControlChars.Tab & "Bandejeo de canapés de entrada" & ControlChars.CrLf
                mRes &= ControlChars.Tab & "Pollo al champignon con papas noissette" & ControlChars.CrLf
                mRes &= ControlChars.Tab & "Helado Charlotte" & ControlChars.CrLf

                If MesaDulce Then
                    mRes &= ControlChars.Tab & "Mesa dulce con variedad de tortas y helado" & ControlChars.CrLf
                    mCubierto += 150
                End If
                If FinDeFiesta Then
                    mRes &= ControlChars.Tab & "Chocolate con churros a las 6 am" & ControlChars.CrLf
                    mCubierto += 100
                End If

                mRes &= ControlChars.Tab & "Bebida: Vino tinto Norton, Agua y Gaseosas. Champagne Chandón para el brindis" & ControlChars.CrLf
                mRes &= "Costo del cubirto: " & mCubierto & ControlChars.CrLf

            Case TipoCatering.CocinaDeAutor
                mCubierto = 1000
                mRes &= ControlChars.Tab & "Tartare de samón" & ControlChars.CrLf
                mRes &= ControlChars.Tab & "Lomo al Malbec acompañado por paillason de papa" & ControlChars.CrLf
                mRes &= ControlChars.Tab & "Petit Gateau au Chocolat" & ControlChars.CrLf

                If MesaDulce Then
                    mRes &= ControlChars.Tab & "Mesa dulce con tortas gourmette y fondue de chocolate" & ControlChars.CrLf
                    mCubierto += 350
                End If
                If FinDeFiesta Then
                    mRes &= ControlChars.Tab & "Café de Colombia con petit fours y masa finas" & ControlChars.CrLf
                    mCubierto += 300
                End If

                mRes &= ControlChars.Tab & "Bebida: Vino DV Catena Cabertet y Champagne Don Perignon. Agua Evian y Gaseosas" & ControlChars.CrLf
                mRes &= "Costo del cubirto: " & mCubierto & ControlChars.CrLf

            Case TipoCatering.MenuInfantil
                mCubierto = 300
                mRes &= ControlChars.Tab & "Papas, palitos y chizitos" & ControlChars.CrLf
                mRes &= ControlChars.Tab & "Panchos y Hamburguesas" & ControlChars.CrLf
                mRes &= ControlChars.Tab & "Helados de palito" & ControlChars.CrLf

                If MesaDulce Then
                    mRes &= ControlChars.Tab & "Mesa dulce con chocotorta, torta de chocolate y golosinas" & ControlChars.CrLf
                    mCubierto += 100
                End If
                If FinDeFiesta Then
                    mRes &= ControlChars.Tab & "Chocolate con churros a las 6 am" & ControlChars.CrLf
                    mCubierto += 100
                End If

                mRes &= ControlChars.Tab & "Bebida: Agua y Gaseosas" & ControlChars.CrLf
                mRes &= "Costo del cubirto: " & mCubierto & ControlChars.CrLf

            Case TipoCatering.PizzaLibre
                mCubierto = 400
                mRes &= ControlChars.Tab & "Bruschettas fiambres y quesos" & ControlChars.CrLf
                mRes &= ControlChars.Tab & "Pizzas de Muzzrella, Cebolla, Calabresa, Napolitana, Rúcula, Provolone, Anchoas y otras" & ControlChars.CrLf
                mRes &= ControlChars.Tab & "Copa de helado con dulce de leche, chocolate y nueces" & ControlChars.CrLf

                If MesaDulce Then
                    mRes &= ControlChars.Tab & "Mesa dulce con variedad de tortas" & ControlChars.CrLf
                    mCubierto += 150
                End If
                If FinDeFiesta Then
                    mRes &= ControlChars.Tab & "Chocolate con churros a las 6 am" & ControlChars.CrLf
                    mCubierto += 100
                End If

                mRes &= ControlChars.Tab & "Bebida: Cerveza tirada, agua y gaseosas" & ControlChars.CrLf
                mRes &= "Costo del cubirto: " & mCubierto & ControlChars.CrLf
        End Select

        mCosto = mCubierto * pCantidad

        mRes &= "Costo total del servicio para " & pCantidad & " invitados: " & mCosto & ControlChars.CrLf

        Return mRes
    End Function


End Class
