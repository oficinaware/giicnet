
Imports ADODB
Imports ADODB.CursorTypeEnum
Imports ADODB.ObjectStateEnum
Imports ADODB.CursorOptionEnum
Imports ADODB.LockTypeEnum
Imports ADODB.FieldAttributeEnum
Imports ADODB.StringFormatEnum
Imports ADODB.PropertyAttributesEnum
Imports ADODB.FieldEnum
Imports Microsoft.VisualBasic
Imports System.Reflection

Public Class ServicosGcom
    Public Function ValidaPrePack(pnrenco As String, plnenco As Long) As Boolean
        Dim prepack As New ADODB.Recordset

        ValidaPrePack = False

        If prepack.State = adStateOpen Then
            prepack.Close()
        End If
        prepack.Open("SELECT * FROM prepack WHERE nrenco = '" & pnrenco & "' AND lnenco = " & plnenco, cnn1, adOpenStatic, adLockReadOnly)
        If Not prepack.EOF Then
            ValidaPrePack = True
        End If


        If prepack.State = adStateOpen Then
            prepack.Close()
        End If

    End Function
    Public Function NOVONR_MORADA() As Long
        Dim PARAM As New ADODB.Recordset
        Dim Moradas As New ADODB.Recordset

        Dim MSG As Object
        Dim NOVONUM As Long


        Dim NUMANT As Double


        If PARAM.State = adStateOpen Then
            PARAM.Close()
        End If
        PARAM.Open("select * from param", cnn1, adOpenStatic, adLockOptimistic)
        PARAM.MoveFirst()
        ' novo numero para MORASAS DE CLIENTES '


        NOVONR_MORADA = 0

        On Error GoTo FIM

        NOVONUM = Nz(PARAM.Fields("pitemcli").Value) + 1

        If Moradas.State = adStateOpen Then
            Moradas.Close()
        End If
        Moradas.Open("select ITEMCLI from MORADAS where ITEMCLI = " & NOVONUM, cnn1, adOpenStatic, adLockReadOnly)
        If Not Moradas.EOF Then
            MSG = MsgBox("Erro ! Numero já existe", vbExclamation)
            NOVONR_MORADA = 0
            GoTo FIM
        End If

        PARAM.Fields("pitemcli").Value = NOVONUM
        PARAM.UpdateBatch()
        NOVONR_MORADA = NOVONUM

FIM:

        If PARAM.State = adStateOpen Then
            PARAM.Close()
        End If
        If Moradas.State = adStateOpen Then
            Moradas.Close()
        End If


    End Function

    Public Function ApagarCartoesViaEnco(pnrenco As String, plnenco As Long) As Boolean
        Dim RsPack As New ADODB.Recordset
        Dim msg As VariantType

        ApagarCartoesViaEnco = True

        'perguntar se tiver packlist sem facturas se é para anular os cartões registados.
        If RsPack.State = adStateOpen Then
            RsPack.Close()
        End If
        RsPack.Open("select * from PACKLIST_ANULA_ENCO where nrenco = '" & pnrenco & "' and lnenco = " & plnenco, cnn1, adOpenStatic, adLockReadOnly)
        If Not RsPack.EOF Then

            RsPack.MoveFirst()
            'valida
            Do While Not RsPack.EOF
                If Nz(RsPack.Fields("ITEMNR").Value, 0) > 1 Then
                    MsgBox("Existem Cartões Multipack S/Faturar... Impossivel Apagar Encomenda. Pack Nr.: " & RsPack.Fields("NRPACK").Value)
                    ApagarCartoesViaEnco = False
                    GoTo FIM
                End If
                RsPack.MoveNext()
                If RsPack.EOF Then
                    Exit Do
                End If
            Loop

            'apagar cartoes
            RsPack.MoveFirst()

            msg = MsgBox("Existem Cartões S/Faturar no Packlist Nr.: " & RsPack.Fields("NRPACK").Value & "  Confirma Apagar Cartoes?", vbOKCancel + vbCritical)
            If msg = vbCancel Then
                ApagarCartoesViaEnco = False
                GoTo FIM
            End If

            Do While Not RsPack.EOF
                cnn1.Execute("DELETE FROM PACKLIST  WHERE (NRPACK = '" & RsPack.Fields("NRPACK").Value & "') And (LNPACK = " & RsPack.Fields("LNPACK").Value & ")")

                Call TotPACKCAB(RsPack.Fields("NRPACK").Value)

                RsPack.MoveNext()
                If RsPack.EOF Then
                    Exit Do
                End If
            Loop



        End If

FIM:

        If RsPack.State = adStateOpen Then
            RsPack.Close()
        End If


    End Function

    Public Function TotPACKCAB(PNRPACK As String)
        Dim PACKCAB As New ADODB.Recordset
        Dim packlist_tot As New ADODB.Recordset

        'TOTAIS NO PACKCAB

        If PACKCAB.State = adStateOpen Then
            PACKCAB.Close()
        End If
        PACKCAB.Open("select * from packcab where NRPACK = " & PNRPACK, cnn1, adOpenStatic, adLockOptimistic)
        If Not PACKCAB.EOF Then

            If packlist_tot.State = adStateOpen Then
                packlist_tot.Close()
            End If
            packlist_tot.Open("select * from packlist_TOT where NRPACK = " & PACKCAB.Fields("NRPACK").Value, cnn1, adOpenStatic, adLockReadOnly)
            If packlist_tot.EOF Then
                With PACKCAB
                    .Fields("NRPARES").Value = 0
                    .Fields("NREMB").Value = 0
                    .Fields("PESOL").Value = 0
                    .Fields("PESOB").Value = 0
                    .Fields("VOLUME").Value = 0
                    .UpdateBatch()
                End With

            Else

                With PACKCAB
                    .Fields("NRPARES").Value = Nz(packlist_tot.Fields("QUANT").Value, 0)
                    .Fields("NREMB").Value = Nz(packlist_tot.Fields("NREMB").Value, 0)
                    .Fields("PESOL").Value = Nz(packlist_tot.Fields("PESOL").Value, 0)
                    .Fields("PESOB").Value = Nz(packlist_tot.Fields("PESOB").Value, 0)
                    .Fields("VOLUME").Value = Nz(packlist_tot.Fields("VOLEMB").Value, 0)
                    .UpdateBatch()
                End With
            End If

        End If
        '---------------------------
        If PACKCAB.State = adStateOpen Then
            PACKCAB.Close()
        End If
        If packlist_tot.State = adStateOpen Then
            packlist_tot.Close()
        End If



    End Function
    Public Function NrCartaoPrePackEnco(pnrenco As String) As Long
        Dim RST As New ADODB.Recordset


        NrCartaoPrePackEnco = 1


        If RST.State = adStateOpen Then
            RST.Close()
        End If

        RST.Open("SELECT MAX(ISNULL(NRCARTAO, 0)) AS NRCARTAO FROM prepack WHERE nrenco = '" & pnrenco & "'", cnn1, adOpenStatic, adLockReadOnly)
        If Not Nz(RST.Fields("NRCARTAO")) Then
            NrCartaoPrePackEnco = Nz(RST.Fields("NRCARTAO"), 0) + 1
        End If



        If RST.State = adStateOpen Then
            RST.Close()
        End If

    End Function

    Public Function NrCartaoPrePack() As Long
        Dim PARAM As New ADODB.Recordset
        Dim pID_NRCARTAO As Long


        If PARAM.State = adStateOpen Then
            PARAM.Close()
        End If


        NrCartaoPrePack = 0

        PARAM.Open("SELECT * FROM PARAM", cnn1, adOpenStatic, adLockOptimistic)
        PARAM.MoveFirst()

        pID_NRCARTAO = Nz(PARAM.Fields("ID_NRCARTAO").Value, 0) + 1

        With PARAM
            If Nz(PARAM.Fields("ID_NRCARTAO_MAX"), 0) = 0 Then
                .Fields("ID_NRCARTAO_MAX").Value = 9999
            End If
            .Fields("ID_NRCARTAO").Value = pID_NRCARTAO
            If pID_NRCARTAO >= Nz(PARAM.Fields("ID_NRCARTAO_MAX"), 0) Then
                .Fields("ID_NRCARTAO").Value = 0
            End If
            .UpdateBatch()
        End With


        NrCartaoPrePack = pID_NRCARTAO

        If PARAM.State = adStateOpen Then
            PARAM.Close()
        End If

    End Function
    'Public Function CapaSem(NrSem As Long, PQT As Integer)
    '    Dim TABSEMCAP As ADODB.Recordset
    '    TABSEMCAP = New ADODB.Recordset

    '    Dim i As Long

    '    'ALTERA CAPACIDADES POR SEMENA

    '    TABSEMCAP.Open("select top 1 * from TABSEMCAP", cnn1, adOpenStatic, adLockOptimistic, adCmdText)
    '    If TABSEMCAP.EOF Then

    '        With TABSEMCAP
    '            .AddNew()
    '            For i = NrSem To NrSem
    '                TABSEMCAP("CAP" & strzero(NrSem, 2)).Value = PQT
    '            Next i
    '            .UpdateBatch()
    '        End With
    '    Else
    '        With TABSEMCAP
    '            For i = NrSem To NrSem
    '                TABSEMCAP("CAP" & strzero(NrSem, 2)).Value = PQT
    '            Next i
    '            .UpdateBatch()
    '        End With
    '    End If


    '    If TABSEMCAP.State = adStateOpen Then
    '        TABSEMCAP.Close()
    '    End If

    'End Function

    Public Function act_pvpr(pmarca As String, pdaest As String, pateest As String, pdomod As String, paomod As String, PCOEF As Double, pcent As Long, popc As Integer)
        Dim MODELOS As New ADODB.Recordset
        Dim escalas As New ADODB.Recordset
        Dim Filtro As String
        Dim X As String, Y As String
        Dim i As Long
        Dim npreco As Double

        Dim xreg As Long
        Dim conta As Long


        Filtro = "marca = '" & pmarca & "' and (estacao between '" & pdaest & "' and '" & pateest & "') and (modelo between '" & pdomod & "' and '" & paomod & "')"
        MODELOS.Open("select * from modelos where " & Filtro, cnn1, adOpenStatic, adLockOptimistic)

        '------------------------
        conta = 0
        xreg = 0
        xreg = MODELOS.RecordCount
        '-------------------------


        ' actualizar pvpr
        Select Case popc
            Case 1
                ' Sivel'
                Do While Not MODELOS.EOF
                    '
                    If escalas.State = adStateOpen Then
                        escalas.Close()
                    End If
                    escalas.Open("select * from escalas where tipsort = '" & MODELOS.Fields("ESCALA").Value & "'", cnn1, adOpenStatic, adLockReadOnly)
                    If Not escalas.EOF Then
                        For i = 1 To 28
                            If Nz(escalas.Fields("T" & strzero(i, 2))).value Then
                                Exit For
                            End If
                            If Nz(MODELOS.Fields("P1" & strzero(i, 2)), 0) > 0 Then
                                ' calculo do novo preco
                                npreco = C_RND(Nz(MODELOS.Fields("P1" & strzero(i, 2)), 0) * PCOEF, 2)
                                npreco = C_RND(npreco, 0)
                                'npreco = npreco - 1
                                npreco = C_RND(npreco + Nz(pcent, 0) / 100, 2)

                                MODELOS.Fields("P3" & strzero(i, 2)).Value = npreco
                            End If
                        Next i
                        MODELOS.UpdateBatch()
                    End If


                    MODELOS.MoveNext()
                    If MODELOS.EOF Then
                        Exit Do
                    End If

                    '--------
                    conta = conta + 1
                    'P_Progresso = Int((conta / xreg) * 100)
                    'P_txtProgresso = Int((conta / xreg) * 100) & "% concluído"
                    'DoEvents()
                    '----------



                Loop
                '
            Case 2
        End Select
        If MODELOS.State = adStateOpen Then
            MODELOS.Close()
        End If



    End Function


    Function CALC_DATA(DT1, dt2, DT3, DT4, DT5, DT6) As Date
        If Not IsDBNull(DT6) Then
            CALC_DATA = DT6
            GoTo FIM
        End If
        If Not IsDBNull(DT5) Then
            CALC_DATA = DT5
            GoTo FIM
        End If
        If Not IsDBNull(DT4) Then
            CALC_DATA = DT4
            GoTo FIM
        End If
        If Not IsDBNull(DT3) Then
            CALC_DATA = DT3
            GoTo FIM
        End If
        If Not IsDBNull(dt2) Then
            CALC_DATA = dt2
            GoTo FIM
        End If
        If Not IsDBNull(DT1) Then
            CALC_DATA = DT1
            GoTo FIM
        End If
FIM:
    End Function

    Public Function nrlin_EC(pnrenco) As Long

        Dim RST As ADODB.Recordset
        RST = New ADODB.Recordset
        RST.Open("conta_LNENCO '" & pnrenco & "'", cnn1, adOpenStatic, adLockReadOnly)
        If RST.EOF Then
            nrlin_EC = 0
        Else
            nrlin_EC = Nz(RST.Fields("maxln").Value, 0)
        End If
        RST.Close()
        RST = Nothing
    End Function
    Public Function nrlin_orctemp(PNrOrc) As Long

        Dim RST As ADODB.Recordset
        RST = New ADODB.Recordset
        RST.Open("conta_orctemp '" & PNrOrc & "'", cnn1, adOpenStatic, adLockReadOnly)
        If RST.EOF Then
            nrlin_orctemp = 0
        Else
            nrlin_orctemp = Nz(RST.Fields("maxln").Value, 0)
        End If
        RST.Close()
        RST = Nothing
    End Function


    Public Function nrlin_encosort(pnrenco As String, plnenco As Long) As Long

        Dim RST As ADODB.Recordset
        RST = New ADODB.Recordset
        RST.Open("conta_Encosort '" & pnrenco & "' ," & plnenco, cnn1, adOpenStatic, adLockReadOnly)
        If RST.EOF Then
            nrlin_encosort = 0
        Else
            nrlin_encosort = Nz(RST.Fields("maxln").Value, 0)
        End If
        RST.Close()
        RST = Nothing
    End Function


    Public Function APAGAR_ENC(pnrenco As String)


        Dim ENCO As ADODB.Recordset, LNENCO As ADODB.Recordset, ENCOPRC As ADODB.Recordset
        Dim ENCOSORT As ADODB.Recordset
        Dim RsPLN As New ADODB.Recordset

        Dim MSG As Object
        Dim mlin As Integer
        ENCO = New ADODB.Recordset
        LNENCO = New ADODB.Recordset
        ENCOPRC = New ADODB.Recordset
        ENCOSORT = New ADODB.Recordset


        ENCO.Open("SELECT * FROM enco WHERE nrenco = '" & pnrenco & "'", cnn1, adOpenStatic, adLockOptimistic)
        If ENCO.EOF = True Then
            MSG = MsgBox("Nr.Enco" & pnrenco & " não existe", vbExclamation)
            GoTo FIM
        End If


        cnn1.Execute("delete from enco_hol where nrenco = '" & pnrenco & "'")
        cnn1.Execute("delete from CARACT_LNENCO where nrenco = '" & pnrenco & "'")


        LNENCO.Open("SELECT * FROM lnenco WHERE lrenco = '" & pnrenco & "'", cnn1, adOpenStatic, adLockOptimistic)
        If Not LNENCO.EOF Then
            Do While LNENCO.Fields("LRENCO").Value = pnrenco

                If ENCOPRC.State = adStateOpen Then
                    ENCOPRC.Close()
                End If

                ENCOPRC.Open("SELECT * FROM encoprc WHERE nrenco = '" & pnrenco & "' AND lnenco = " & LNENCO.Fields("LNENCO").Value, cnn1, adOpenStatic, adLockOptimistic)
                If Not ENCOPRC.EOF Then
                    Do While ENCOPRC.Fields("NRENCO").Value = LNENCO.Fields("LRENCO").Value And ENCOPRC.Fields("LNENCO").Value = ENCOPRC.Fields("LNENCO").Value
                        ENCOPRC.Delete()
                        ENCOPRC.MoveNext()
                        If ENCOPRC.EOF Then
                            Exit Do
                        End If
                    Loop
                End If
                '
                If ENCOSORT.State = adStateOpen Then
                    ENCOSORT.Close()
                End If

                ENCOSORT.Open("SELECT * FROM encosort WHERE nrenco = '" & LNENCO.Fields("LRENCO").Value & "' AND lnenco = " & LNENCO.Fields("LNENCO").Value, cnn1, adOpenStatic, adLockOptimistic)

                If Not ENCOSORT.EOF Then
                    Do While ENCOSORT.Fields("NRENCO").Value = LNENCO.Fields("LRENCO").Value And ENCOSORT.Fields("LNENCO").Value = LNENCO.Fields("LNENCO").Value
                        ENCOSORT.Delete()
                        ENCOSORT.MoveNext()
                        If ENCOSORT.EOF Then
                            Exit Do
                        End If
                    Loop
                End If
                '

                ' por agora
                Call APAGAR_NEC("EC", LNENCO.Fields("LRENCO").Value, LNENCO.Fields("LNENCO").Value)
                Call DEL_PREPACK(LNENCO.Fields("LRENCO").Value, LNENCO.Fields("LNENCO").Value)


                If RsPLN.State = adStateOpen Then
                    RsPLN.Close()
                End If
                RsPLN.Open("SELECT IDPLAN, COUNT(LRENCO) AS Nr_IdPlan FROM LNENCO GROUP BY IDPLAN HAVING IDPLAN = " & Nz(LNENCO.Fields("IDPLAN"), 0), cnn1, adOpenStatic, adLockReadOnly)
                If Not RsPLN.EOF Then
                    If Nz(RsPLN.Fields("Nr_IdPlan"), 0) = 1 Then
                        cnn1.Execute("DELETE FROM planning_ec WHERE ordfab = '" & strzero(Nz(RsPLN.Fields("IDPLAN"), 0), 6) & "'")
                    End If
                End If




                LNENCO.Delete()
                LNENCO.MoveNext()
                If LNENCO.EOF Then
                    Exit Do
                End If
            Loop
        End If
        '
        ENCO.Delete()

        MsgBox("Apagou Encomenda com sucesso")

        GoTo FIM
err1:
        MsgBox(Err.Description)

FIM:


        If ENCO.State = adStateOpen Then
            ENCO.Close()
        End If
        If LNENCO.State = adStateOpen Then
            LNENCO.Close()
        End If
        If ENCOPRC.State = adStateOpen Then
            ENCOPRC.Close()
        End If
        If ENCOSORT.State = adStateOpen Then
            ENCOSORT.Close()
        End If
        If RsPLN.State = adStateOpen Then
            RsPLN.Close()
        End If
    End Function
    Public Function APAGAR_LENC(pnrenco As String, plnenco As Long)

        Dim LNENCO As ADODB.Recordset
        Dim ENCOPRC As ADODB.Recordset
        Dim ENCOSORT As ADODB.Recordset
        Dim MSG As Object
        Dim mlin As Integer

        ENCOPRC = New ADODB.Recordset
        ENCOSORT = New ADODB.Recordset
        LNENCO = New ADODB.Recordset

        Dim RsPLN As New ADODB.Recordset


        ENCOPRC.Open("SELECT * FROM encoprc WHERE nrenco = '" & pnrenco & "' AND lnenco = " & plnenco, cnn1, adOpenStatic, adLockOptimistic)

        If Not ENCOPRC.EOF Then
            Do While ENCOPRC.Fields("NRENCO").Value = pnrenco And ENCOPRC.Fields("LNENCO").Value = plnenco
                ENCOPRC.Delete()
                ENCOPRC.MoveNext()
                If ENCOPRC.EOF Then
                    Exit Do
                End If
            Loop
        End If

        ENCOSORT.Open("SELECT * FROM encosort WHERE nrenco = '" & pnrenco & "' AND lnenco = " & plnenco, cnn1, adOpenStatic, adLockOptimistic)

        If Not ENCOSORT.EOF Then
            Do While ENCOSORT.Fields("NRENCO").Value = pnrenco And ENCOSORT.Fields("LNENCO").Value = plnenco
                ENCOSORT.Delete()
                ENCOSORT.MoveNext()
                If ENCOSORT.EOF Then
                    Exit Do
                End If
            Loop
        End If

        Call APAGAR_NEC("EC", pnrenco, plnenco)
        Call DEL_PREPACK(pnrenco, plnenco)

        cnn1.Execute("delete from enco_hol where nrenco = '" & pnrenco & "' AND LNENCO = " & plnenco)
        cnn1.Execute("delete from CARACT_LNENCO where nrenco = '" & pnrenco & "' AND LNENCO = " & plnenco)


        LNENCO.Open("SELECT * FROM LNENCO WHERE LRENCO = '" & pnrenco & "' AND LNENCO = " & plnenco, cnn1, adOpenStatic, adLockOptimistic)
        If Not LNENCO.EOF Then

            If RsPLN.State = adStateOpen Then
                RsPLN.Close()
            End If
            RsPLN.Open("SELECT IDPLAN, COUNT(LRENCO) AS Nr_IdPlan FROM LNENCO GROUP BY IDPLAN HAVING IDPLAN = " & Nz(LNENCO.Fields("IDPLAN").Value, 0), cnn1, adOpenStatic, adLockReadOnly)
            If Not RsPLN.EOF Then
                If Nz(RsPLN.Fields("Nr_IdPlan").Value, 0) = 1 Then
                    cnn1.Execute("DELETE FROM planning_ec WHERE ordfab = '" & strzero(Nz(RsPLN.Fields("IDPLAN").Value, 0), 6) & "'")
                End If
            End If

            LNENCO.Delete()
        End If

        MsgBox("Apagou Encomenda com sucesso")

        GoTo FIM
err1:
        MsgBox(Err.Description)

FIM:

        If ENCOSORT.State = adStateOpen Then
            ENCOSORT.Close()
        End If
        If ENCOPRC.State = adStateOpen Then
            ENCOPRC.Close()
        End If
        If LNENCO.State = adStateOpen Then
            LNENCO.Close()
        End If
        If RsPLN.State = adStateOpen Then
            RsPLN.Close()
        End If

    End Function


    Function APAGAR_NEC(PCOD As String, pnrenco As String, plnenco As Long)
        'Dim DBA As Database
        Dim STKNEC As ADODB.Recordset
        'Set DBA = OpenDatabase(diravent)
        STKNEC = New ADODB.Recordset
        'Set stknec = DBA.OpenRecordset("STKNEC")
        'stknec.Index = "PRIMARYKEY"
        STKNEC.Open("SELECT * FROM stknec WHERE cod = '" & PCOD & "' and nrenco = '" & pnrenco & "' AND lnenco = " & plnenco, cnn1, adOpenStatic, adLockOptimistic)

        'stknec.Seek ">=", PCOD, pnrenco, plnenco
        If Not STKNEC.EOF Then
            Do While STKNEC.Fields("COD").Value = PCOD And STKNEC.Fields("NRENCO").Value = pnrenco And STKNEC.Fields("LNENCO").Value = plnenco
                'MsgBox (" Apagou " & STKNEC!ARTIGO & " da Enc Nr: " & STKNEC!NRENCO & STKNEC!LNENCO & "  -  " & STKNEC!SEQNEC)
                STKNEC.Delete()
                STKNEC.MoveNext()
                If STKNEC.EOF Then
                    Exit Do
                End If
            Loop
            'MsgBox ("Registos Apagados...")
            GoTo FIM
        End If
        'msgbox ("Operação não executada...")
FIM:
        STKNEC.Close()
        STKNEC = Nothing
    End Function
    Public Function DEL_PREPACK(pnrenco, plnenco)
        'Dim DB As Database
        Dim prepack As ADODB.Recordset
        'Set DB = OpenDatabase(DIRECTORIO)
        'Set prepack = db.OpenRecordset("PREPACK")
        'prepack.Index = "PRIMARYKEY"
        prepack = New ADODB.Recordset
        prepack.Open("SELECT * FROM prepack WHERE nrenco = '" & pnrenco & "' AND lnenco = " & plnenco, cnn1, adOpenStatic, adLockOptimistic)

        'prepack.Seek ">=", pnrenco, plnenco
        If Not prepack.EOF Then
            Do While prepack.Fields("NRENCO") = pnrenco And prepack.Fields("LNENCO").Value = plnenco
                prepack.Delete()
                prepack.MoveNext()
                If prepack.EOF Then
                    Exit Do
                End If
            Loop
        End If
        prepack.Close()
        prepack = Nothing
        'DB.Close
    End Function

    Public Sub c_plafond(PCLIENTE As String)
        Dim CLIENTES As New ADODB.Recordset
        Dim RSTenco As New ADODB.Recordset
        Dim i As Long


        For i = 0 To 4
            PLAF(i) = 0
        Next i

        plafond_atrib = 0


        If CLIENTES.State = adStateOpen Then
            CLIENTES.Close()
        End If
        CLIENTES.Open("SELECT * FROM clientes WHERE cliente = '" & PCLIENTE & "'", cnn1, adOpenStatic, adLockReadOnly)
        If CLIENTES.EOF Then
            GoTo FINAL
        End If

        plafond_atrib = Nz(CLIENTES.Fields("PLAFOND"), 0)

        If RSTenco.State = adStateOpen Then
            RSTenco.Close()
        End If
        RSTenco.Open("SELECT * FROM ValorEncPendentes_CIVA WHERE cliente = '" & PCLIENTE & "'", cnn1, adOpenStatic, adLockReadOnly)
        If Not RSTenco.EOF Then
            PLAF(0) = C_RND(Nz(RSTenco.Fields("totvl").Value, 0), 2)
        End If

        ' por agora
        'If p_ligacc = True Then
        '    Call PLAFOND_CC(p_aplicacao_cc, "2", PCLIENTE)
        '    Call PLAFOND_GR(PCLIENTE)
        'End If



FINAL:


        If CLIENTES.State = adStateOpen Then
            CLIENTES.Close()
        End If
        If RSTenco.State = adStateOpen Then
            RSTenco.Close()
        End If

    End Sub

    'Public Sub PLAFOND_CC(PAPLICACAO, PTERCEIRO, PCLIENTE)
    '        Dim cn_cc As ADODB.Connection
    '        'cn_cc = CurrentProject.Connection
    '        Dim TIPO_ENTID As String
    '        Dim pendentes As ADODB.Recordset
    '        Dim historico As ADODB.Recordset
    '        Dim tiposconta As ADODB.Recordset
    '        Dim TABEURO As ADODB.Recordset
    '        Dim tabdoc As ADODB.Recordset
    '        Dim XFACTOR As Double
    '        Dim VLPEND As Double
    '        'aqui

    '        Select Case Trim(PAPLICACAO)
    '            '------------------------------------------------------------------------------------
    '            Case "Primavera_v4.50"
    '                pendentes = New ADODB.Recordset
    '                tiposconta = New ADODB.Recordset

    '                Select Case PTERCEIRO
    '                    Case 2
    '                        TIPO_ENTID = "C"
    '                    Case 3
    '                        TIPO_ENTID = "F"
    '                End Select
    '                pendentes.Open("select * from pendentes where tipoentidade = '" & TIPO_ENTID & "' and entidade = '" & PCLIENTE & "'", cn_cc, adOpenStatic, adLockReadOnly, adCmdText)
    '                If pendentes.EOF Then
    '                    GoTo FIM
    '                End If
    '                Do While pendentes!TipoEntidade = TIPO_ENTID And pendentes!Entidade = PCLIENTE
    '                    XFACTOR = Nz(pendentes!CAMBIO, 1)
    '                    'tiposconta.Seek "=", pendentes!TIPOCONTA
    '                    tiposconta.Open("select * from tiposconta where conta = '" & pendentes!TIPOCONTA & "'", cn_cc, adOpenStatic, adLockReadOnly, adCmdText)
    '                    If Not tiposconta.EOF Then
    '                        'msgbox (pendentes!entidade & " - " & pendentes!valorpendente)
    '                        VLPEND = C_RND(Nz(pendentes!valorpendente, 0) / XFACTOR, 2)
    '                        If p_moeda = "PTE" Then
    '                            VLPEND = C_RND(VLPEND * 200.482, 0)
    '                        End If
    '                        Select Case tiposconta!TIPOCONTA
    '                            Case "C"
    '                                PLAF(2) = PLAF(2) + VLPEND
    '                            Case "T"
    '                                PLAF(3) = PLAF(3) + VLPEND
    '                        End Select
    '                    End If
    '                    tiposconta.Close()
    '                    pendentes.MoveNext()
    '                    If pendentes.EOF Then
    '                        Exit Do
    '                    End If
    '                Loop
    '                pendentes.Close()

    '                '------------------------------------------------------------------------------------
    '            Case "Primavera_SQL6", "Primavera_SQL8"
    '                pendentes = New ADODB.Recordset
    '                tiposconta = New ADODB.Recordset

    '                Select Case PTERCEIRO
    '                    Case 2
    '                        TIPO_ENTID = "C"
    '                    Case 3
    '                        TIPO_ENTID = "F"
    '                End Select
    '                pendentes.Open("select * from Prima_pendentes where tipoentidade = '" & TIPO_ENTID & "' and entidade = '" & PCLIENTE & "'", cn_cc, adOpenStatic, adLockReadOnly, adCmdText)
    '                If pendentes.EOF Then
    '                    GoTo FIM
    '                End If
    '                Do While pendentes!TipoEntidade = TIPO_ENTID And pendentes!Entidade = PCLIENTE
    '                    XFACTOR = Nz(pendentes!CAMBIO, 1)

    '                    If tiposconta.State = adStateOpen Then
    '                        tiposconta.Close()
    '                    End If
    '                    tiposconta.Open("select * from Prima_tiposconta where conta = '" & pendentes!TIPOCONTA & "'", cn_cc, adOpenStatic, adLockReadOnly, adCmdText)
    '                    If Not tiposconta.EOF Then
    '                        VLPEND = C_RND(Nz(pendentes!valorpendente, 0) / XFACTOR, 2)
    '                        If p_moeda = "PTE" Then
    '                            VLPEND = C_RND(VLPEND * 200.482, 0)
    '                        End If
    '                        Select Case tiposconta!TIPOCONTA
    '                            Case "C"
    '                                PLAF(2) = PLAF(2) + VLPEND
    '                            Case "T"
    '                                PLAF(3) = PLAF(3) + VLPEND
    '                        End Select
    '                    End If
    '                    pendentes.MoveNext()
    '                    If pendentes.EOF Then
    '                        Exit Do
    '                    End If
    '                Loop

    '                If pendentes.State = adStateOpen Then
    '                    pendentes.Close()
    '                End If
    '                If tiposconta.State = adStateOpen Then
    '                    tiposconta.Close()
    '                End If
    '                '--------------------------------------------------------------------------
    '            Case "Oficina_v1.0"
    '                'Set DB = OpenDatabase(DIRECTORIO)
    '                'Set DBCC = OpenDatabase(DIRCC)
    '                'Set DBA = OpenDatabase(diravent)

    '                'Set pendentes = DBCC.OpenRecordset("pndcli")
    '                'pendentes.Index = "pndcli1"
    '                'Set tiposconta = DBCC.OpenRecordset("tiposconta")
    '                'tiposconta.Index = "tiposconta01"
    '                'Set TABDOC = DBA.OpenRecordset("tabdoc")
    '                'TABDOC.Index = "primarykey"
    '                'Set TABEURO = db.OpenRecordset("tabeuro")
    '                'TABEURO.Index = "primarykey"
    '                pendentes = New ADODB.Recordset
    '                'Set TABDOC = New ADODB.Recordset
    '                'Set tabeuro = New ADODB.Recordset

    '                Select Case PTERCEIRO
    '                    Case 2
    '                        TIPO_ENTID = "2"
    '                    Case 3
    '                        TIPO_ENTID = "3"
    '                End Select
    '                'pendentes.Seek ">=", TIPO_ENTID, pcliente
    '                pendentes.Open("select * from pndcli where terceiro = '" & TIPO_ENTID & "' and cliente = '" & PCLIENTE & "'", cn_cc, adOpenStatic, adLockReadOnly, adCmdText)
    '                If pendentes.EOF Then
    '                    GoTo FIM
    '                End If
    '                Do While pendentes!TERCEIRO = TIPO_ENTID And pendentes!CLIENTE = PCLIENTE
    '                    XFACTOR = Nz(pendentes!CAMBIO, 1)
    '                    VLPEND = C_RND(Nz(pendentes!pendente, 0) / XFACTOR, 2)
    '                    If pendentes!TIPO = "C" Then
    '                        VLPEND = -VLPEND
    '                    End If
    '                    If p_moeda = "PTE" Then
    '                        VLPEND = C_RND(VLPEND * 200.482, 0)
    '                    End If
    '                    'tiposconta.Seek "=", pendentes!TIPOCONTA
    '                    'If Not tiposconta.NoMatch Then
    '                    'Select Case tiposconta!TIPOCONTA
    '                    Select Case pendentes!tpcnt
    '                        Case "C"
    '                            PLAF(2) = PLAF(2) + VLPEND
    '                        Case "L"
    '                            PLAF(3) = PLAF(3) + VLPEND
    '                        Case "Q"
    '                            PLAF(4) = PLAF(4) + VLPEND
    '                    End Select
    '                    'End If
    '                    pendentes.MoveNext()
    '                    If pendentes.EOF Then
    '                        Exit Do
    '                    End If
    '                Loop
    '                pendentes.Close()
    '        End Select
    'FIM:

    '        If pendentes.State = adStateOpen Then
    '            pendentes.Close()
    '        End If

    '    End Sub

    '    Public Sub PLAFOND_GR(PCLIENTE)
    '        Dim RST As ADODB.Recordset
    '        RST = New ADODB.Recordset

    '        RST.Open("DOC_FATCAB_PORFACTURAR '" & PCLIENTE & "'", cnn1, adOpenStatic, adLockReadOnly)
    '        PLAF(1) = 0
    '        Do While Not RST.EOF
    '            PLAF(1) = PLAF(1) + C_RND(Nz(RST!totvl, 0), 2)
    '            RST.MoveNext()
    '        Loop
    '        RST.Close()
    '        RST = Nothing
    '    End Sub

    Public Function NOVAENC(ptpdoc As String, ficheiro As String) As Object

        Dim tabdoc As ADODB.Recordset, RST As ADODB.Recordset, MSG As Object
        Dim NOVONUM As Long, NUMANT As Long
        
        tabdoc = New ADODB.Recordset
        RST = New ADODB.Recordset
        ' novo numero para documento '
inicio:
        NOVAENC = vbNull
        tabdoc.Open("select * from tabdoc where tipodoc = '" & ptpdoc & "'", cnn1, adOpenStatic, adLockOptimistic)
        'TABDOC.Seek "=", ptpdoc
        If tabdoc.EOF Then
            MSG = MsgBox("Tipo Doc " & ptpdoc & " não existe", vbExclamation)
            GoTo FIM
        End If

        On Error GoTo FIM
        NOVONUM = Nz(tabdoc.Fields("NUMERADOR").Value) + 1
        

        RST.Open("select * from " & ficheiro & " where nrenco = '" & strzero(NOVONUM, 6) & "'", cnn1, adOpenStatic, adLockOptimistic)
        'rst.Seek "=", strzero(NOVONUM, 6)
        If Not RST.EOF Then
            MSG = MsgBox("Erro ! Numero já existe", vbExclamation)
            NOVAENC = vbNull
            GoTo FIM
        End If
        ' Ver se existe o nr.anterior e avisa caso não exista
        RST.Close()
        NUMANT = NOVONUM - 1
        RST.Open("select * from " & ficheiro & " where nrenco = '" & strzero(NUMANT, 6) & "'", cnn1, adOpenStatic, adLockOptimistic)
        'rst.Seek "=", strzero(numant, 6)
        If RST.EOF Then
            MSG = MsgBox("Erro ! Numero anterior  " & ptpdoc & Str(NUMANT) & " não existe" & Chr(13) & _
            " Alterar numerador em tabela de Documentos ", vbExclamation)
            'With tabdoc
            '.Edit
            '!NUMERADOR = !NUMERADOR - 1
            '.Update
            'End With
            'GoTo inicio
            'NOVONUMERO = 0
            'GoTo fim
        End If
continua:
        'TABDOC.Edit
        tabdoc.Fields("NUMERADOR").Value = NOVONUM
        tabdoc.Update()
        tabdoc.Close()
        RST.Close()
        NOVAENC = strzero(NOVONUM, 6)
FIM:
    End Function

    '
    ' aqui

    '
    '    Public Function VALIDA_PRECO_FACT(ptpdoc As String, PNRFACT As Long, PLNFACT As Long) As Boolean
    '        Dim FATCAB As New ADODB.Recordset
    '        Dim FATLIN As New ADODB.Recordset
    '        Dim FATPRC As New ADODB.Recordset
    '        Dim TABEURO As New ADODB.Recordset

    '        Dim qtt As Double, TVAL As Double
    '        Dim PMOEDA As String
    '        Dim i As Long, MDEC As Integer
    '        Dim qtesc As Double
    '        Dim X As String

    '        VALIDA_PRECO_FACT = True
    '        qtt = 0
    '        TVAL = 0
    '        FATCAB.Open("select moeda from FATCAB where TPDOC = '" & ptpdoc & "' AND NRFACT = " & PNRFACT, cnn1, adOpenStatic, adLockReadOnly)
    '        If FATCAB.EOF Then
    '            MsgBox("Doc cabeçalho não existe")
    '            PMOEDA = p_moeda
    '        Else
    '            PMOEDA = FATCAB!MOEDA
    '        End If

    '        TABEURO.Open("select * from tabeuro where moeda = '" & PMOEDA & "'", cnn1, adOpenStatic, adLockReadOnly)
    '        If TABEURO.EOF Then
    '            MDEC = 2
    '        Else
    '            MDEC = Nz(TABEURO!DECIMAIS, 2)
    '        End If

    '        FATLIN.Open("select * from FATLIN where TPDOC = '" & ptpdoc & "' AND NRFACT = " & PNRFACT & " AND LNFACT = " & PLNFACT, cnn1, adOpenStatic, adLockReadOnly)
    '        If FATLIN.EOF Then
    '            MsgBox("LINHA DOC não existe")
    '            VALIDA_PRECO_FACT = False
    '            GoTo FIM
    '        End If


    '        qtt = 0

    '        FATPRC.Open("select * from FATPRC where TPDOC = '" & ptpdoc & "' AND NRFACT = " & PNRFACT & " AND LNFACT = " & PLNFACT, cnn1, adOpenStatic, adLockReadOnly)
    '        If Not FATPRC.EOF Then
    '            With FATPRC
    '                Do While !TPDOC = ptpdoc And !NRFACT = PNRFACT And !lnfact = PLNFACT
    '                    qtesc = 0
    '                    For i = !IDOTAM To !IAOTAM
    '                        X = "QE" & strzero(i, 2)
    '                        qtesc = qtesc + Val(Nz(FATLIN(X)))
    '                    Next i
    '                    TVAL = TVAL + C_RND(qtesc * FATPRC!PRECO, MDEC)
    '                    qtt = qtt + qtesc
    '                    .MoveNext()
    '                    If .EOF() Then
    '                        Exit Do
    '                    End If
    '                    If (!TPDOC <> ptpdoc Or !NRFACT <> PNRFACT Or !lnfact <> PLNFACT) Then
    '                        Exit Do
    '                    End If
    '                Loop
    '            End With


    '            If qtt <> Nz(FATLIN!QUANT, 0) Then
    '                MsgBox("Calculo de Valor Errado!Quantidades sem Preço na linha " & ptpdoc & PNRFACT & "/" & PLNFACT)
    '                VALIDA_PRECO_FACT = False
    '                GoTo FIM
    '            End If

    '        Else

    '            If TVAL = 0 Then
    '                MsgBox("Doc/Linha " & ptpdoc & PNRFACT & "/" & PLNFACT & " sem preços...")
    '                VALIDA_PRECO_FACT = False
    '                GoTo FIM
    '            End If


    '        End If

    'FIM:


    '        If FATPRC.State = adStateOpen Then
    '            FATPRC.Close()
    '        End If
    '        If FATCAB.State = adStateOpen Then
    '            FATCAB.Close()
    '        End If
    '        If FATLIN.State = adStateOpen Then
    '            FATLIN.Close()
    '        End If
    '        If TABEURO.State = adStateOpen Then
    '            TABEURO.Close()
    '        End If
    '    End Function

    '    Public Function VALIDA_PRECO_ENCO(pnrenco As String, plnenco) As Boolean
    '        Dim ENCO As New ADODB.Recordset
    '        Dim LNENCO As New ADODB.Recordset
    '        Dim ENCOPRC As New ADODB.Recordset
    '        Dim TABEURO As New ADODB.Recordset

    '        Dim qtt As Double, TVAL As Double
    '        Dim PMOEDA As String
    '        Dim i As Long, MDEC As Integer
    '        Dim qtesc As Double
    '        Dim X As String

    '        VALIDA_PRECO_ENCO = True
    '        qtt = 0
    '        TVAL = 0
    '        ENCO.Open("select moeda from ENCO where NRENCO = '" & pnrenco & "'", cnn1, adOpenStatic, adLockReadOnly)
    '        If ENCO.EOF Then
    '            MsgBox("Encomenda cabeçalho não existe")
    '            PMOEDA = p_moeda
    '        Else
    '            PMOEDA = ENCO!MOEDA
    '        End If

    '        TABEURO.Open("select * from tabeuro where moeda = '" & PMOEDA & "'", cnn1, adOpenStatic, adLockReadOnly)
    '        If TABEURO.EOF Then
    '            MDEC = 2
    '        Else
    '            MDEC = Nz(TABEURO!DECIMAIS, 2)
    '        End If

    '        LNENCO.Open("select * from LNENCO where LRENCO = '" & pnrenco & "' AND LNENCO = " & plnenco, cnn1, adOpenStatic, adLockReadOnly)
    '        If LNENCO.EOF Then
    '            MsgBox("LINHA ENCO não existe")
    '            VALIDA_PRECO_ENCO = False
    '            GoTo FIM
    '        End If


    '        qtt = 0

    '        ENCOPRC.Open("select * from ENCOPRC where NRENCO = '" & pnrenco & "' and LNENCO = " & plnenco, cnn1, adOpenStatic, adLockReadOnly)
    '        If Not ENCOPRC.EOF Then
    '            With ENCOPRC
    '                Do While !NRENCO = pnrenco And !LNENCO = plnenco
    '                    qtesc = 0
    '                    For i = !IDOTAM To !IAOTAM
    '                        X = "QE" & strzero(i, 2)
    '                        qtesc = qtesc + Val(Nz(LNENCO(X)))
    '                    Next i
    '                    TVAL = TVAL + C_RND(qtesc * ENCOPRC!PRECO, MDEC)
    '                    qtt = qtt + qtesc
    '                    .MoveNext()
    '                    If .EOF() Then
    '                        Exit Do
    '                    End If
    '                    If (!NRENCO <> pnrenco Or !LNENCO <> plnenco) Then
    '                        Exit Do
    '                    End If
    '                Loop
    '            End With



    '            If qtt <> Nz(LNENCO!TOTAL, 0) Then
    '                MsgBox("Calculo de Valor Errado!Quantidades sem Preço na linha " & pnrenco & "/" & plnenco)
    '                VALIDA_PRECO_ENCO = False
    '                GoTo FIM
    '            End If

    '        Else

    '            If TVAL = 0 Then
    '                MsgBox("enco/Linha " & pnrenco & "/" & plnenco & " sem preços...")
    '                VALIDA_PRECO_ENCO = False
    '                GoTo FIM
    '            End If


    '        End If

    'FIM:


    '        If ENCOPRC.State = adStateOpen Then
    '            ENCOPRC.Close()
    '        End If
    '        If ENCO.State = adStateOpen Then
    '            ENCO.Close()
    '        End If
    '        If LNENCO.State = adStateOpen Then
    '            LNENCO.Close()
    '        End If
    '        If TABEURO.State = adStateOpen Then
    '            TABEURO.Close()
    '        End If
    '    End Function

    'Public Function cprecoenc(pnrenco, plnenco, Optional TIPO As Integer, Optional TPRC As Integer) As Double
    '        ' tipo: 1 - qt enc
    '        ' tipo: 2 - qtenc - qtexp
    '        ' tipo: 3 - qtexp
    '        ' caso não exista assume 2
    '        ' TPRC -> TPRC CASO 1 -> PRECO DE COMPRA DO ARTIGO , CASO 2 PRECO DE CUSTO DO ARTIGO, OUTROS É O PREÇO DA ENC
    '        Dim LNENCO As ADODB.Recordset
    '        Dim MODELOS As ADODB.Recordset
    '        Dim ENCOPRC As ADODB.Recordset
    '        Dim TABEURO As ADODB.Recordset
    '        Dim ENCO As ADODB.Recordset

    '        Dim qtt As Double, TVAL As Double
    '        Dim PMOEDA As String
    '        Dim i As Long, MDEC As Integer
    '        Dim j As Long
    '        Dim k As String
    '        Dim W As Long
    '        Dim APRECO_OC As Double, APRECO_CUSTO As Double
    '        Dim TVAL_OC As Double, TVAL_CUSTO As Double
    '        Dim qtesc As Double
    '        Dim X As String, Y As String

    '        '
    '        LNENCO = New ADODB.Recordset
    '        ENCOPRC = New ADODB.Recordset
    '        TABEURO = New ADODB.Recordset
    '        ENCO = New ADODB.Recordset
    '        MODELOS = New ADODB.Recordset
    '        '

    '        qtt = 0
    '        TVAL = 0
    '        'enco.Seek "=", pnrenco
    '        ENCO.Open("SELECT * FROM enco WHERE nrenco = '" & pnrenco & "'", cnn1, adOpenStatic, adLockReadOnly)
    '        If ENCO.EOF Then
    '            MsgBox("Encomenda cabeçalho não existe")
    '            PMOEDA = p_moeda
    '        Else
    '            PMOEDA = ENCO!MOEDA
    '        End If

    '        'TABEURO.Seek "=", PMOEDA
    '        TABEURO.Open("SELECT * FROM tabeuro WHERE moeda = '" & PMOEDA & "'", cnn1, adOpenStatic, adLockReadOnly)
    '        If TABEURO.EOF Then
    '            MDEC = 0
    '        Else
    '            MDEC = TABEURO!DECIMAIS
    '        End If

    '        'LNENCO.Seek "=", pnrenco, plnenco
    '        LNENCO.Open("SELECT * FROM lnenco WHERE lrenco = '" & pnrenco & "' AND lnenco = " & plnenco, cnn1, adOpenStatic, adLockReadOnly, adCmdText)
    '        If LNENCO.EOF Then
    '            MsgBox("Linha de Encomenda " & pnrenco & "-" & Nz(plnenco, "  ") & " não existe.")
    '            cprecoenc = 0
    '            GoTo FIM
    '        End If
    '        qtt = 0

    '        ' CALCULO DO PRECO DE COMPRA E DE CUSTO
    '        ' VER CASO MOEDA <> EUR NA COMPRA
    '        TVAL_CUSTO = 0
    '        TVAL_OC = 0
    '        If LNENCO!STATUSLN = True Or ENCO!STATUSNR = True Then
    '            GoTo siga
    '        End If
    '        For j = 1 To 28
    '            X = "QE" & strzero(j, 2)
    '            Y = "QX" & strzero(j, 2)
    '            k = "T" & strzero(j, 2)
    '            If IsNull(LNENCO(k)) Then
    '                Exit For
    '            End If

    '            If (Nz(LNENCO(X), 0) - Nz(LNENCO(Y), 0)) > 0 Then
    '                ' VER PREÇO DO MODELO
    '                'MODELOS.Seek "=", LNENCO!MODELO, LNENCO!VARIANTE
    '                If MODELOS.State = adStateOpen Then
    '                    MODELOS.Close()
    '                End If

    '                MODELOS.Open("select * from modelos where modelo = '" & LNENCO!MODELO & "' and variante = '" & LNENCO!VARIANTE & "'", cnn1, adOpenStatic, adLockReadOnly, adCmdText)
    '                If Not MODELOS.EOF Then
    '                    APRECO_CUSTO = 0
    '                    APRECO_OC = 0
    '                    For W = 1 To j
    '                        If Nz(MODELOS("POC" & strzero(W, 2)), 0) > 0 Then
    '                            APRECO_OC = Nz(MODELOS("POC" & strzero(W, 2)), 0)
    '                        End If
    '                        If Nz(MODELOS("PC" & strzero(W, 2)), 0) > 0 Then
    '                            APRECO_CUSTO = Nz(MODELOS("PC" & strzero(W, 2)), 0)
    '                        End If
    '                        '
    '                    Next W
    '                    TVAL_CUSTO = TVAL_CUSTO + ((APRECO_CUSTO) * (Nz(LNENCO(X), 0) - Nz(LNENCO(Y), 0)))
    '                    TVAL_OC = TVAL_OC + ((APRECO_OC) * (Nz(LNENCO(X), 0) - Nz(LNENCO(Y), 0)))
    '                End If
    '            End If
    '        Next j
    '        '
    'siga:

    '        'encoprc.Seek ">=", pnrenco, FILLESQ(plnenco, 2)
    '        ENCOPRC.Open("SELECT * FROM encoprc WHERE nrenco = '" & pnrenco & "' AND lnenco = " & plnenco, cnn1, adOpenStatic, adLockReadOnly, adCmdText)
    '        If Not ENCOPRC.EOF Then
    '            With ENCOPRC
    '                Do While !NRENCO = pnrenco And !LNENCO = plnenco
    '                    qtesc = 0
    '                    For i = !IDOTAM To !IAOTAM
    '                        X = "QE" & strzero(i, 2)
    '                        Y = "QX" & strzero(i, 2)
    '                        If IsMissing(TIPO) Or TIPO = 2 Then
    '                            If LNENCO!STATUSLN = True Then
    '                                qtesc = 0
    '                            Else
    '                                qtesc = qtesc + Val(Nz(LNENCO(X))) - Val(Nz(LNENCO(Y), 0))
    '                            End If
    '                        End If
    '                        '
    '                        If TIPO = 3 Then
    '                            If LNENCO!STATUSLN = True Then
    '                                qtesc = 0
    '                            Else
    '                                qtesc = qtesc + Val(Nz(LNENCO(Y), 0))
    '                            End If
    '                        End If
    '                        '
    '                        If TIPO = 1 Then
    '                            If LNENCO!STATUSLN = True Then
    '                                qtesc = 0
    '                            Else
    '                                qtesc = qtesc + Val(Nz(LNENCO(X)))
    '                            End If
    '                        End If
    '                    Next i
    '                    TVAL = TVAL + C_RND(qtesc * ENCOPRC!PRECO, MDEC)
    '                    qtt = qtt + qtesc
    '                    .MoveNext()
    '                    If .EOF() Then
    '                        Exit Do
    '                    End If
    '                    If (!NRENCO <> pnrenco Or !LNENCO <> plnenco) Then
    '                        Exit Do
    '                    End If
    '                Loop
    '            End With
    '        End If
    '        If qtt <> LNENCO!TOTAL And TIPO = 1 Then
    '            'MsgBox ("Quantidades sem Preço.")
    '            cprecoenc = 0
    '            GoTo FIM
    '        End If
    '        If IsMissing(TPRC) Then
    '            cprecoenc = Nz(TVAL, 0)
    '            GoTo FIM
    '        End If
    '        If TPRC = 1 Then
    '            cprecoenc = C_RND(TVAL_OC, MDEC)
    '            GoTo FIM
    '        End If
    '        If TPRC = 2 Then
    '            cprecoenc = C_RND(TVAL_CUSTO, MDEC)
    '            GoTo FIM
    '        End If
    '        cprecoenc = Nz(TVAL, 0)
    'FIM:

    '        If LNENCO.State = adStateOpen Then
    '            LNENCO.Close()
    '        End If
    '        If ENCOPRC.State = adStateOpen Then
    '            ENCOPRC.Close()
    '        End If
    '        If TABEURO.State = adStateOpen Then
    '            TABEURO.Close()
    '        End If
    '        If ENCO.State = adStateOpen Then
    '            ENCO.Close()
    '        End If
    '        If MODELOS.State = adStateOpen Then
    '            MODELOS.Close()
    '        End If



    '    End Function


    '    Public Function regrava_ENCO(PNRFACT)
    '        VL(1) = 0
    '        VL(2) = 0
    '        VL(3) = 0
    '        Dim MDEC As Integer
    '        Dim MMOEDA As Object
    '        Dim PLNFACT As Long
    '        Dim TVAL As Double
    '        Dim qtt As Double
    '        Dim X As String
    '        Dim TDESCL As Double
    '        Dim qtesc As Long
    '        Dim ttval As Double
    '        Dim i As Long
    '        Dim subtot1 As Double
    '        Dim totqty As Double
    '        Dim XPORTES As Double
    '        Dim XDESCONTOS As Double
    '        Dim XVALLIQ As Double
    '        Dim XSUJIVA As Double
    '        Dim ttdescln As Double

    '        Dim FATCAB As ADODB.Recordset
    '        Dim FATLIN As ADODB.Recordset
    '        Dim FATPRC As ADODB.Recordset
    '        Dim TABEURO As ADODB.Recordset
    '        'Set db = OpenDatabase(DIRECTORIO)
    '        'Set dba = OpenDatabase(diravent)
    '        'Set fatcab = db.OpenRecordset("ENCO")
    '        'fatcab.Index = "primarykey"
    '        'Set FATLIN = db.OpenRecordset("LNENCO")
    '        'FATLIN.Index = "primarykey"
    '        'Set fatprc = db.OpenRecordset("ENCOPRC")
    '        'fatprc.Index = "primarykey"
    '        'Set tabeuro = db.OpenRecordset("tabeuro")
    '        'tabeuro.Index = "primarykey"
    '        FATCAB = New ADODB.Recordset
    '        FATLIN = New ADODB.Recordset
    '        FATPRC = New ADODB.Recordset
    '        TABEURO = New ADODB.Recordset

    '        'fatcab.Seek "=", pnrfact
    '        FATCAB.Open("select * from enco where nrenco = '" & PNRFACT & "'", cnn1, adOpenStatic, adLockOptimistic)
    '        If FATCAB.EOF Then
    '            MsgBox("Documento não existe... ")
    '            GoTo FIM
    '        End If
    '        MMOEDA = FATCAB!MOEDA
    '        If IsNull(MMOEDA) Then
    '            MMOEDA = p_moeda
    '        End If

    '        'tabeuro.Seek "=", MMOEDA
    '        TABEURO.Open("select * from tabeuro where moeda = '" & MMOEDA & "'", cnn1, adOpenStatic, adLockReadOnly)
    '        If TABEURO.EOF Then
    '            MDEC = 0
    '        Else
    '            MDEC = TABEURO!DECIMAIS
    '        End If
    '        totqty = 0
    '        ttval = 0
    '        ttdescln = 0

    '        'FATLIN.Seek ">=", pnrfact
    '        FATLIN.Open("select * from lnenco where lrenco = '" & PNRFACT & "'", cnn1, adOpenStatic, adLockOptimistic)
    '        If Not FATLIN.EOF Then
    '            Do While FATLIN!LRENCO = PNRFACT
    '                PLNFACT = FATLIN!LNENCO
    '                qtt = 0
    '                TVAL = 0
    '                TDESCL = 0

    '                'fatprc.Seek ">=", pnrfact, PLNFACT
    '                FATPRC.Open("select * from encoprc where nrenco = '" & PNRFACT & "' and lnenco = " & PLNFACT, cnn1, adOpenStatic, adLockReadOnly)
    '                If Not FATPRC.EOF Then
    '                    With FATPRC
    '                        Do While !NRENCO = PNRFACT And !LNENCO = PLNFACT
    '                            qtesc = 0
    '                            For i = !IDOTAM To !IAOTAM
    '                                X = "QE" & strzero(i, 2)
    '                                qtesc = qtesc + Val(Nz(FATLIN(X)))
    '                            Next i
    '                            TVAL = TVAL + C_RND(qtesc * FATPRC!PRECO, MDEC)
    '                            qtt = qtt + qtesc
    '                            .MoveNext()
    '                            If .EOF() Then
    '                                Exit Do
    '                            End If
    '                            If (!NRENCO <> PNRFACT Or !LNENCO <> PLNFACT) Then
    '                                Exit Do
    '                            End If

    '                            'If fatprc.State = adStateOpen Then
    '                            'fatprc.Close
    '                            'End If

    '                        Loop
    '                    End With

    '                    If qtt <> Nz(FATLIN!TOTAL) Then
    '                        'MsgBox ("Calculo de Valor Errado!Quantidades sem Preço na linha " & PLNFACT)
    '                    End If
    '                Else
    '                    'MsgBox ("Linha " & PLNFACT & " sem preços...")
    '                End If
    '                TDESCL = C_RND(TVAL * Nz(FATLIN!DESCL1ENC) / 100, MDEC)
    '                'totqty = totqty + Nz(fatlin!TOTAL)
    '                With FATLIN
    '                    '.Edit
    '                    !VALORENC = TVAL
    '                    !DESCLENC = TDESCL
    '                    .UpdateBatch()
    '                End With
    '                'ttval = ttval + TVAL
    '                'ttdescln = ttdescln + TDESCL
    '                FATLIN.MoveNext()
    '                If FATLIN.EOF Then
    '                    Exit Do
    '                End If

    '                If FATPRC.State = adStateOpen Then
    '                    FATPRC.Close()
    '                End If

    '            Loop


    '            'VL(1) = ttval
    '            'VL(2) = ttdescln
    '            'VL(3) = totqty

    '            'With fatcab
    '            '!VALORENC = ttval
    '            '!TDESCLNENC = ttdescln
    '            '!TOTALENC = totqty
    '            '.UpdateBatch
    '            'End With
    '        End If
    'FIM:

    '        If FATPRC.State = adStateOpen Then
    '            FATPRC.Close()
    '        End If
    '        If FATLIN.State = adStateOpen Then
    '            FATLIN.Close()
    '        End If
    '        If FATCAB.State = adStateOpen Then
    '            FATCAB.Close()
    '        End If
    '        If TABEURO.State = adStateOpen Then
    '            TABEURO.Close()
    '        End If

    '    End Function

    '    Public Function copyenc(P_DAENCO As String, PCLIENTE As String, PPRAZO As Date)

    '        ' copiar encomendas

    '        Dim ENCO As ADODB.Recordset
    '        Dim enco1 As ADODB.Recordset
    '        Dim LNENCO As ADODB.Recordset
    '        Dim LNENCO1 As ADODB.Recordset
    '        Dim ENCOPRC As ADODB.Recordset
    '        Dim encoprc1 As ADODB.Recordset
    '        Dim ENCOSORT As ADODB.Recordset
    '        Dim ENCOSORT1 As ADODB.Recordset

    '        Dim mnrenco As String
    '        'Dim db As Database
    '        Dim MSG As Object
    '        Dim i As Integer
    '        Dim NOMECAMPO As String


    '        ENCO = New ADODB.Recordset
    '        enco1 = New ADODB.Recordset
    '        LNENCO = New ADODB.Recordset
    '        LNENCO1 = New ADODB.Recordset
    '        ENCOPRC = New ADODB.Recordset
    '        encoprc1 = New ADODB.Recordset
    '        ENCOSORT = New ADODB.Recordset
    '        ENCOSORT1 = New ADODB.Recordset

    '        '
    '        'enco1.Seek "=", P_DAENCO
    '        enco1.Open("select * from enco where nrenco = '" & P_DAENCO & "'", cnn1, adOpenStatic, adLockReadOnly, adCmdText)
    '        If enco1.EOF = True Then
    '            MSG = MsgBox("Enco Origem " & P_DAENCO & " não existe", vbExclamation)
    '            GoTo FIM
    '        End If

    '        If p_encoauto = True Then
    '            mnrenco = NOVAENC("EC", "ENCO")
    '            If IsNull(mnrenco) Then
    '                MsgBox("Erro... numerador da encomenda")
    '                GoTo FIM
    '            End If
    '        Else
    '            ENCO.MoveLast()
    '            mnrenco = strzero(Val(ENCO!NRENCO) + 1, 6)
    '        End If

    '        'enco.Seek "=", MNRENCO
    '        ENCO.Open("select * from enco where nrenco = '" & mnrenco & "'", cnn1, adOpenStatic, adLockOptimistic, adCmdText)
    '        If Not (ENCO.EOF) Then
    '            MSG = MsgBox("Encomenda Destino " & mnrenco & " já existe", vbExclamation)
    '            GoTo FIM
    '        End If

    '        With ENCO
    '            .AddNew()
    '            For i = 0 To .Fields.Count - 1
    '                NOMECAMPO = .Fields(i).Name
    '                If NOMECAMPO = "totalenc" Or NOMECAMPO = "totalexp" Or NOMECAMPO = "totsaldo" Or NOMECAMPO = "valorenc" Or NOMECAMPO = "valorexp" Or NOMECAMPO = "tdesclnenc" Or NOMECAMPO = "DESCONTOS" Or NOMECAMPO = "rowguid" Then
    '                    GoTo siga
    '                End If
    '                .Fields(i) = enco1.Fields(i)
    'siga:
    '            Next i
    '            !NRENCO = mnrenco
    '            !CLIENTE = PCLIENTE
    '!DATAENCO = Date
    '            !PRAZO = PPRAZO
    '            !STATUSNR = False
    '            .UpdateBatch()
    '        End With
    '        '

    '        NOMECAMPO = ""
    '        LNENCO1.Open("select * from lnenco where lrenco = '" & P_DAENCO & "'", cnn1, adOpenStatic, adLockReadOnly, adCmdText)
    '        If Not LNENCO1.EOF Then
    '            Do While LNENCO1!LRENCO = P_DAENCO And Not LNENCO1.EOF
    '                'LNENCO.Seek "=", MNRENCO, lnenco1!LNENCO
    '                If LNENCO.State = adStateOpen Then
    '                    LNENCO.Close()
    '                End If
    '                LNENCO.Open("select * from lnenco where lrenco = '" & mnrenco & "' and lnenco = " & LNENCO1!LNENCO, cnn1, adOpenStatic, adLockOptimistic, adCmdText)
    '                If Not LNENCO.EOF Then
    '                    MsgBox("erro... linha " & LNENCO1!LNENCO & " ja existe...")
    '                Else
    '                    With LNENCO
    '                        .AddNew()
    '                        For i = 0 To .Fields.Count - 1
    '                            NOMECAMPO = .Fields(i).Name
    '                            If Mid(NOMECAMPO, 1, 2) = "QL" Or Mid(NOMECAMPO, 1, 2) = "QI" Or Mid(NOMECAMPO, 1, 2) = "QO" Or Mid(NOMECAMPO, 1, 2) = "QP" Or Mid(NOMECAMPO, 1, 2) = "QX" Or Mid(NOMECAMPO, 1, 3) = "QEA" Then
    '                                GoTo SIGA1
    '                            End If
    '                            If NOMECAMPO = "TOTLAN" Or NOMECAMPO = "TOTIN" Or NOMECAMPO = "TOTOUT" Or NOMECAMPO = "TOTEXP" Or NOMECAMPO = "TOTEA" Or _
    '                            NOMECAMPO = "TOTEMB" Or NOMECAMPO = "saldo" Or NOMECAMPO = "valorenc" Or _
    '                            NOMECAMPO = "desclenc" Or NOMECAMPO = "valorexp" Or NOMECAMPO = "ultimoprazo" Or NOMECAMPO = "semana" Or _
    '                            NOMECAMPO = "datafim" Or NOMECAMPO = "prazofab" Or NOMECAMPO = "prazo1" Or NOMECAMPO = "prazo2" Or NOMECAMPO = "prazo3" Or NOMECAMPO = "prazo4" Or NOMECAMPO = "rowguid" Then
    '                                GoTo SIGA1
    '                            End If
    '                            .Fields(i) = LNENCO1.Fields(i)
    'SIGA1:
    '                        Next i
    '                        !LRENCO = mnrenco
    '                        !PRAZO = PPRAZO
    '                        !STATUSLN = False
    '                        !STATVM = False
    '                        .UpdateBatch()
    '                    End With
    '                    '
    '                End If
    '                LNENCO1.MoveNext()
    '                If LNENCO1.EOF Then
    '                    Exit Do
    '                End If
    '            Loop

    '            ' sortidos
    '            'ENCOSORT1.Seek ">=", P_DAENCO
    '            NOMECAMPO = ""
    '            ENCOSORT1.Open("select * from encosort where nrenco = '" & P_DAENCO & "'", cnn1, adOpenStatic, adLockReadOnly, adCmdText)
    '            If Not ENCOSORT1.EOF Then
    '                Do While ENCOSORT1!NRENCO = P_DAENCO And Not ENCOSORT1.EOF
    '                    If ENCOSORT.State = adStateOpen Then
    '                        ENCOSORT.Close()
    '                    End If
    '                    ENCOSORT.Open("select * from encosort where nrenco = '" & mnrenco & "' and lnenco = " & ENCOSORT1!LNENCO & " and pos = " & ENCOSORT1!POS, cnn1, adOpenStatic, adLockOptimistic, adCmdText)
    '                    If Not ENCOSORT.EOF Then
    '                        MsgBox("erro... linha " & ENCOSORT!LNENCO & " ja existe em sortidos...")
    '                    Else
    '                        With ENCOSORT
    '                            .AddNew()
    '                            For i = 0 To .Fields.Count - 1
    '                                NOMECAMPO = .Fields(i).Name
    '                                If NOMECAMPO = "rowguid" Then
    '                                    GoTo SIGA2
    '                                End If
    '                                .Fields(i) = ENCOSORT1.Fields(i)
    'SIGA2:
    '                            Next i
    '                            !NRENCO = mnrenco
    '                            .UpdateBatch()
    '                        End With
    '                    End If
    '                    ENCOSORT1.MoveNext()
    '                    If ENCOSORT1.EOF Then
    '                        Exit Do
    '                    End If
    '                Loop
    '            End If
    '            '
    '            ' Precos
    '            '
    '            NOMECAMPO = ""
    '            encoprc1.Open("select * from encoprc where nrenco = '" & P_DAENCO & "'", cnn1, adOpenStatic, adLockReadOnly, adCmdText)
    '            If Not encoprc1.EOF Then
    '                Do While encoprc1!NRENCO = P_DAENCO And Not encoprc1.EOF
    '                    If ENCOPRC.State = adStateOpen Then
    '                        ENCOPRC.Close()
    '                    End If
    '                    ENCOPRC.Open("select * from encoprc where nrenco = '" & mnrenco & "' and lnenco = " & encoprc1!LNENCO & " and idotam = " & encoprc1!IDOTAM, cnn1, adOpenStatic, adLockOptimistic, adCmdText)
    '                    If Not ENCOPRC.EOF Then
    '                        MsgBox("erro... linha " & ENCOPRC!LNENCO & " ja existe...")
    '                    Else
    '                        With ENCOPRC
    '                            .AddNew()
    '                            For i = 0 To .Fields.Count - 1
    '                                NOMECAMPO = .Fields(i).Name
    '                                If NOMECAMPO = "rowguid" Then
    '                                    GoTo SIGA3
    '                                End If
    '                                .Fields(i) = encoprc1.Fields(i)
    'SIGA3:
    '                            Next i
    '                            !NRENCO = mnrenco
    '                            .UpdateBatch()
    '                        End With
    '                    End If
    '                    encoprc1.MoveNext()
    '                    If encoprc1.EOF Then
    '                        Exit Do
    '                    End If
    '                Loop
    '            End If
    '            '
    '        End If


    '        Call regrava_ENCO(mnrenco)


    '        'wrk.CommitTrans
    '        MSG = MsgBox("Nova Encomenda Nr " & mnrenco & " Registada com Sucesso", vbExclamation)
    '        GoTo FIM

    'err_lock:
    '        MSG = MsgBox("Registo não disponivel")
    '        'wrk.Rollback
    '        GoTo FIM
    'ERR:
    '        MsgBox("erro no update - " & Err.Number & Err.Description)
    '        'wrk.Rollback
    'FIM:

    '        If ENCO.State = adStateOpen Then
    '            ENCO.Close()
    '        End If
    '        If enco1.State = adStateOpen Then
    '            enco1.Close()
    '        End If
    '        If LNENCO.State = adStateOpen Then
    '            LNENCO.Close()
    '        End If
    '        If LNENCO1.State = adStateOpen Then
    '            LNENCO1.Close()
    '        End If
    '        If ENCOPRC.State = adStateOpen Then
    '            ENCOPRC.Close()
    '        End If
    '        If encoprc1.State = adStateOpen Then
    '            encoprc1.Close()
    '        End If
    '        If ENCOSORT.State = adStateOpen Then
    '            ENCOSORT.Close()
    '        End If
    '        If ENCOSORT1.State = adStateOpen Then
    '            ENCOSORT1.Close()
    '        End If


    '    End Function


    '    Public Function id_Sort(pESCALA As String, PTOTQT As Integer, AQT() As Integer) As String
    '        Dim SORTIDOS As ADODB.Recordset
    '        Dim escalas As ADODB.Recordset
    '        Dim TOK As Boolean
    '        Dim ns As String
    '        Dim i As Long
    '        Dim MSG As Object

    '        SORTIDOS = New ADODB.Recordset
    '        escalas = New ADODB.Recordset
    '        TOK = False

    '        If PTOTQT >= P_QtSort Then
    '            MSG = MsgBox("Atençao: Total de Sortido " & PTOTQT & " Confirma Registar...", vbOKCancel + vbCritical)
    '            If MSG = vbCancel Then
    '                id_Sort = "0"
    '                GoTo FIM
    '            End If
    '        End If

    '        escalas.Open("SELECT * FROM ESCALAS WHERE TIPSORT = '" & pESCALA & "'", cnn1, adOpenStatic, adLockReadOnly)
    '        If escalas.EOF Then
    '            MsgBox("Escala " & pESCALA & " não existe...")
    '            id_Sort = "ERRO"
    '            GoTo FIM
    '        End If
    '        SORTIDOS.Open("SELECT * FROM SORTIDOS WHERE ESCALA = '" & pESCALA & "' AND TOTQT = " & PTOTQT, cnn1, adOpenStatic, adLockReadOnly)
    '        If SORTIDOS.EOF Then
    '            ns = NOVO_SORT(pESCALA, AQT)
    '            If ns = "ERRO" Then
    '                MsgBox("Erro na geração do novo sortido...")
    '                id_Sort = "ERRO"
    '                GoTo FIM
    '            Else
    '                id_Sort = ns
    '                GoTo FIM
    '            End If
    '        End If
    '        Do While Not SORTIDOS.EOF
    '            TOK = True
    '            For i = 1 To 28
    '                If IsNull(escalas("T" & strzero(i, 2))) Then
    '                    Exit For
    '                End If
    '                If Nz(SORTIDOS("QE" & strzero(i, 2)), 0) <> Nz(AQT(i), 0) Then
    '                    TOK = False
    '                    Exit For
    '                End If
    '            Next i
    '            If TOK = True Then
    '                id_Sort = SORTIDOS!TIPSORT
    '                GoTo FIM
    '            End If
    '            '
    '            SORTIDOS.MoveNext()
    '            If SORTIDOS.EOF Then
    '                Exit Do
    '            End If
    '        Loop
    '        '
    '        ns = NOVO_SORT(pESCALA, AQT())
    '        If ns = "ERRO" Then
    '            MsgBox("Erro na geração do novo sortido...")
    '            id_Sort = "ERRO"
    '            GoTo FIM
    '        Else
    '            id_Sort = ns
    '        End If
    'FIM:
    '        If escalas.State = adStateOpen Then
    '            escalas.Close()
    '        End If
    '        If SORTIDOS.State = adStateOpen Then
    '            SORTIDOS.Close()
    '        End If

    '    End Function

    '    Public Function NOVO_SORT(pESCALA As String, PQT() As Integer) As String
    '        Dim i As Long, TQT As Long
    '        Dim escalas As ADODB.Recordset, SORTIDOS As ADODB.Recordset
    '        escalas = New ADODB.Recordset
    '        SORTIDOS = New ADODB.Recordset
    '        escalas.Open("SELECT * FROM ESCALAS WHERE TIPSORT = '" & pESCALA & "'", cnn1, adOpenStatic, adLockOptimistic)
    '        If escalas.EOF Then
    '            NOVO_SORT = "ERRO"
    '            GoTo FIM
    '        End If
    '        ns = strzero(Nz(escalas!IDSORT, 0) + 1, 5)
    '        SORTIDOS.Open("SELECT * FROM SORTIDOS WHERE TIPSORT = '" & ns & "' AND ESCALA = '" & pESCALA & "'", cnn1, adOpenStatic, adLockOptimistic)
    '        If Not SORTIDOS.EOF Then
    '            MsgBox("Sortido gerado " & ns & " já existe...")
    '            NOVO_SORT = "ERRO"
    '            GoTo FIM
    '        End If

    '        With escalas
    '            !IDSORT = Nz(!IDSORT, 0) + 1
    '            .Update()
    '        End With
    '        '
    '        With SORTIDOS
    '            .AddNew()
    '            !TIPSORT = ns
    '            !ESCALA = pESCALA
    '            TQT = 0
    '            For i = 1 To 28
    '                If IsNull(escalas("T" & strzero(i, 2))) Then
    '                    Exit For
    '                End If
    '                If Nz(PQT(i), 0) > 0 Then
    '                    SORTIDOS("QE" & strzero(i, 2)) = Nz(PQT(i), 0)
    '                    TQT = TQT + Nz(PQT(i), 0)
    '                End If
    '            Next i
    '            '!TOTQT = tqt
    '            .Update()
    '        End With

    '        NOVO_SORT = ns

    'FIM:
    '        If escalas.State = adStateOpen Then
    '            escalas.Close()
    '        End If
    '        If SORTIDOS.State = adStateOpen Then
    '            SORTIDOS.Close()
    '        End If

    '    End Function



End Class
