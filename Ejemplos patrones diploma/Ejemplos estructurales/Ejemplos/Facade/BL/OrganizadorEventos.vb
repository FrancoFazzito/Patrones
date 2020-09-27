''' <summary>
''' FACADE
''' </summary>
''' <remarks></remarks>
Public Class OrganizadorEventos

    Public Enum TipoGasto
        AltaFiesta
        FestejoCompleto
        FiestaModerada
        ReunionFamiliar
    End Enum

    Public Function OrganizarCasamiento(pInvitados As Integer, pFecha As DateTime, pGasto As TipoGasto) As String
        Dim mRes As String = "PRESUPUESTO CASAMIENTO PARA " & pInvitados & " INVITADOS" & ControlChars.CrLf
        Dim mCostoTotal As Double = 0
        Select Case pGasto
            Case TipoGasto.AltaFiesta
                Dim mSalon As New Salon
                mRes &= mSalon.Reservar(pInvitados, pFecha)
                mCostoTotal += mSalon.Costo

                Dim mDJ As New DiscJockey
                mDJ.EfectosLaser = True
                mDJ.Iluminacion = True
                mDJ.MaquinaHumo = True
                mRes &= mDJ.Contratar(pInvitados, pFecha)
                mCostoTotal += mDJ.Costo

                Dim mCat As New Catering
                mCat.Tipo = Catering.TipoCatering.CocinaDeAutor
                mCat.FinDeFiesta = True
                mCat.MesaDulce = True
                mRes &= mCat.Contratar(pInvitados, pFecha)
                mCostoTotal += mCat.Costo

                Dim mAnim As New Animador
                mAnim.Nivel = Animador.NivelAnimacion.Exclusivo
                mAnim.Tipo = Animador.TipoAnimacion.Adultos
                mRes &= mAnim.Contratar(pFecha)
                mCostoTotal += mAnim.Costo

                Dim mFot As New Fotografo
                mFot.Camaras = 5
                mFot.Video = True
                mRes &= mFot.Contratar(pInvitados, pFecha)
                mCostoTotal += mFot.Costo

                Dim mCot As New Cotillon
                mRes &= mCot.Contratar(pInvitados, pFecha)
                mCostoTotal += mCot.Costo

                Dim mTr As New Transporte
                mTr.Tipo = Transporte.TipoTransporte.Limo
                mRes &= mTr.Contratar(pFecha)
                mCostoTotal += mTr.Costo

            Case TipoGasto.FestejoCompleto
                Dim mSalon As New Salon
                mRes &= mSalon.Reservar(pInvitados, pFecha)
                mCostoTotal += mSalon.Costo

                Dim mDJ As New DiscJockey
                mDJ.EfectosLaser = False
                mDJ.Iluminacion = True
                mDJ.MaquinaHumo = True
                mRes &= mDJ.Contratar(pInvitados, pFecha)
                mCostoTotal += mDJ.Costo

                Dim mCat As New Catering
                mCat.Tipo = Catering.TipoCatering.Clasico
                mCat.FinDeFiesta = True
                mCat.MesaDulce = True
                mRes &= mCat.Contratar(pInvitados, pFecha)
                mCostoTotal += mCat.Costo

                Dim mAnim As New Animador
                mAnim.Nivel = Animador.NivelAnimacion.Normal
                mAnim.Tipo = Animador.TipoAnimacion.Adultos
                mRes &= mAnim.Contratar(pFecha)
                mCostoTotal += mAnim.Costo

                Dim mFot As New Fotografo
                mFot.Camaras = 2
                mFot.Video = True
                mRes &= mFot.Contratar(pInvitados, pFecha)
                mCostoTotal += mFot.Costo

                Dim mCot As New Cotillon
                mRes &= mCot.Contratar(pInvitados, pFecha)
                mCostoTotal += mCot.Costo

                Dim mTr As New Transporte
                mTr.Tipo = Transporte.TipoTransporte.CocheClasico
                mRes &= mTr.Contratar(pFecha)
                mCostoTotal += mTr.Costo

            Case TipoGasto.FiestaModerada
                Dim mSalon As New Salon
                mRes &= mSalon.Reservar(pInvitados, pFecha)
                mCostoTotal += mSalon.Costo

                Dim mDJ As New DiscJockey
                mDJ.EfectosLaser = False
                mDJ.Iluminacion = False
                mDJ.MaquinaHumo = False
                mRes &= mDJ.Contratar(pInvitados, pFecha)
                mCostoTotal += mDJ.Costo

                Dim mCat As New Catering
                mCat.Tipo = Catering.TipoCatering.PizzaLibre
                mCat.FinDeFiesta = False
                mCat.MesaDulce = False
                mRes &= mCat.Contratar(pInvitados, pFecha)
                mCostoTotal += mCat.Costo

                Dim mAnim As New Animador
                mAnim.Nivel = Animador.NivelAnimacion.Economico
                mAnim.Tipo = Animador.TipoAnimacion.Adultos
                mRes &= mAnim.Contratar(pFecha)
                mCostoTotal += mAnim.Costo

                Dim mFot As New Fotografo
                mFot.Camaras = 1
                mFot.Video = False
                mRes &= mFot.Contratar(pInvitados, pFecha)
                mCostoTotal += mFot.Costo


            Case TipoGasto.ReunionFamiliar
                Dim mSalon As New Salon
                mRes &= mSalon.Reservar(pInvitados, pFecha)
                mCostoTotal += mSalon.Costo

                Dim mDJ As New DiscJockey
                mDJ.EfectosLaser = False
                mDJ.Iluminacion = False
                mDJ.MaquinaHumo = False
                mRes &= mDJ.Contratar(pInvitados, pFecha)
                mCostoTotal += mDJ.Costo

                Dim mCat As New Catering
                mCat.Tipo = Catering.TipoCatering.PizzaLibre
                mCat.FinDeFiesta = False
                mCat.MesaDulce = False
                mRes &= mCat.Contratar(pInvitados, pFecha)
                mCostoTotal += mCat.Costo


        End Select
        mRes &= "COSTO TOTAL: " & mCostoTotal
        Return mRes

    End Function

    Public Function OrgenizarCumpleInfantil(pInvitados As Integer, pFecha As DateTime, pGasto As TipoGasto) As String
        Dim mRes As String = "PRESUPUESTO CASAMIENTO PARA " & pInvitados & " INVITADOS" & ControlChars.CrLf
        Dim mCostoTotal As Double = 0
        Select Case pGasto
            Case TipoGasto.AltaFiesta, TipoGasto.FestejoCompleto
                Dim mSalon As New Salon
                mRes &= mSalon.Reservar(pInvitados, pFecha)
                mCostoTotal += mSalon.Costo

                Dim mDJ As New DiscJockey
                mDJ.EfectosLaser = True
                mDJ.Iluminacion = True
                mDJ.MaquinaHumo = True
                mRes &= mDJ.Contratar(pInvitados, pFecha)
                mCostoTotal += mDJ.Costo

                Dim mCat As New Catering
                mCat.Tipo = Catering.TipoCatering.MenuInfantil
                mCat.FinDeFiesta = True
                mCat.MesaDulce = True
                mRes &= mCat.Contratar(pInvitados, pFecha)
                mCostoTotal += mCat.Costo

                Dim mAnim As New Animador
                mAnim.Nivel = Animador.NivelAnimacion.Exclusivo
                mAnim.Tipo = Animador.TipoAnimacion.Infantil
                mRes &= mAnim.Contratar(pFecha)
                mCostoTotal += mAnim.Costo

                Dim mFot As New Fotografo
                mFot.Camaras = 5
                mFot.Video = True
                mRes &= mFot.Contratar(pInvitados, pFecha)
                mCostoTotal += mFot.Costo

                Dim mCot As New Cotillon
                mRes &= mCot.Contratar(pInvitados, pFecha)
                mCostoTotal += mCot.Costo

                Dim mTr As New Transporte
                mTr.Tipo = Transporte.TipoTransporte.Trencito
                mRes &= mTr.Contratar(pFecha)
                mCostoTotal += mTr.Costo

            Case TipoGasto.FiestaModerada
                Dim mSalon As New Salon
                mRes &= mSalon.Reservar(pInvitados, pFecha)
                mCostoTotal += mSalon.Costo

                Dim mDJ As New DiscJockey
                mDJ.EfectosLaser = False
                mDJ.Iluminacion = False
                mDJ.MaquinaHumo = False
                mRes &= mDJ.Contratar(pInvitados, pFecha)
                mCostoTotal += mDJ.Costo

                Dim mCat As New Catering
                mCat.Tipo = Catering.TipoCatering.MenuInfantil
                mCat.FinDeFiesta = False
                mCat.MesaDulce = False
                mRes &= mCat.Contratar(pInvitados, pFecha)
                mCostoTotal += mCat.Costo

                Dim mAnim As New Animador
                mAnim.Nivel = Animador.NivelAnimacion.Economico
                mAnim.Tipo = Animador.TipoAnimacion.Infantil
                mRes &= mAnim.Contratar(pFecha)
                mCostoTotal += mAnim.Costo

                Dim mFot As New Fotografo
                mFot.Camaras = 1
                mFot.Video = False
                mRes &= mFot.Contratar(pInvitados, pFecha)
                mCostoTotal += mFot.Costo

                Dim mCot As New Cotillon
                mRes &= mCot.Contratar(pInvitados, pFecha)
                mCostoTotal += mCot.Costo


            Case TipoGasto.ReunionFamiliar
                Dim mSalon As New Salon
                mRes &= mSalon.Reservar(pInvitados, pFecha)
                mCostoTotal += mSalon.Costo

                Dim mCat As New Catering
                mCat.Tipo = Catering.TipoCatering.MenuInfantil
                mCat.FinDeFiesta = False
                mCat.MesaDulce = False
                mRes &= mCat.Contratar(pInvitados, pFecha)
                mCostoTotal += mCat.Costo

                Dim mAnim As New Animador
                mAnim.Nivel = Animador.NivelAnimacion.Economico
                mAnim.Tipo = Animador.TipoAnimacion.Infantil
                mRes &= mAnim.Contratar(pFecha)
                mCostoTotal += mAnim.Costo

        End Select
        mRes &= "COSTO TOTAL: " & mCostoTotal
        Return mRes
    End Function


End Class
