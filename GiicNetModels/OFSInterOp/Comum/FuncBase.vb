
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

Module FuncBase
    Public cnn1 As ADODB.Connection
    Public cnn2 As ADODB.Connection
    Public PTIMEOUT As Long
    
    Public P_VersaoSQL As Object

    Public p_EmpCertificada As Boolean
    Public P_VersaoChave As Long
    Public P_ProductId As Object
    Public P_ProductVersion As Object
    Public P_ProductCertificationNumber As Object
    Public PSERIE As String

    Public P_DIRMAPAS As Object
    Public P_DirImportEnco As Object
    Public p_ImportEncoExcel As Object
    Public P_DirSaft As Object
    Public p_arm As String
    Public p_armPa As String
    Public P_ABRIR As Boolean, P_NOVO As Boolean, P_EDIT As Boolean, P_DEL As Boolean
    Public P_UTENTE As String
    Public P_GRUPO As String
    Public P_MultiIVA As Boolean
    Public P_TXIVA As Double
    Public P_TaxRegion As String
    Public P_ISENTOIVA_INTER As String
    Public P_ISENTOIVA_EXTRA As String

    Public p_moeda As String
    Public p_nivel As Long
    Public p_ConfVar As Long
    Public p_internacional As Boolean
    Public p_lingua As Long
    Public p_ligacc As Boolean

    Public P_LigaEmpresa As Boolean
    Public P_TipoPrecoEsp As Long
    Public P_TipoBD As Long
    Public P_GestaoSALTOS As Boolean
    Public P_TipoFT_SA As Long
    Public P_ValidaModCli As Boolean
    Public P_VerPrc2EC As Boolean
    Public p_GeraAutoEAN As Boolean

    Public p_ctrlplafond As Long
    Public plafond_ok As Boolean
    Public plafond_atrib As Double
    Public p_passplaf As Object
    Public p_passSAFT As Object
    Public P_RegPrepack As Boolean
    Public P_QtSort As Integer
    Public p_dtfechostk As Date
    Public Edita_doc As String

    Public p_aplicacao_cc As Object
    Public P_IMPRIMELOGO As Boolean
    Public P_LOCAL_EMISSAO As Object
    Public p_desc1 As Object, p_desc2 As Object, p_desc3 As Object, p_desc4 As Object, p_desc5 As Object
    Public p_desc_i1 As Object, p_desc_i2 As Object, p_desc_i3 As Object, p_desc_i4 As Object, p_desc_i5 As Object
    Public p_desc_F1 As Object, p_desc_F2 As Object, p_desc_F3 As Object, p_desc_F4 As Object, p_desc_F5 As Object

    Public t_desc1 As Object, t_desc2 As Object, t_desc3 As Object, t_desc4 As Object, t_desc5 As Object
    Public t_desc_i1 As Object, t_desc_i2 As Object, t_desc_i3 As Object, t_desc_i4 As Object, t_desc_i5 As Object
    Public t_desc_F1 As Object, t_desc_F2 As Object, t_desc_F3 As Object, t_desc_F4 As Object, t_desc_F5 As Object

    Public P_DESCORC1 As Object, P_DESCORC2 As Object, P_DESCORC3 As Object, P_DESCORC4 As Object, P_DESCORC5 As Object, P_DESCORC6 As Object, P_DESCORC7 As Object
    Public P_GGF As Double, P_MARGMP As Double, P_MARGMO As Double, P_MARGVND As Double, P_COMISSAO As Double, P_CUSTFIN As Double, P_RETORNO As Double
    Public p_ferramenta As Long
    Public p_ftec As Object, p_forc As Object
    Public p_desccom As Boolean
    Public P_CopiaPRC As Boolean
    Public P_AltTempoRota As Boolean

    Public p_opdesc As Long
    Public P_PRCSTD As Long
    Public p_encoauto As Boolean
    Public nova_encomenda As Boolean
    Public p_necmat1 As Object, p_necmat2 As Object, p_necmat3 As Object
    Public P_DATACC As Date
    Public P_DATACC_FECHO As Date

    Public P_RESERVA_PA As Boolean
    Public P_VPN As Boolean
    Public p_convgr As Long
    Public p_expetiq As Boolean
    Public P_DIRFOTO As Object
    Public P_DIRFOTOART As Object
    Public P_EXTFOTO As Object
    Public P_ValidarStocks As Boolean
    Public P_DadosEnco As Boolean

    Public p_empresa As Object, p_marca As Object, p_ptelef As Object, p_pfax As Object, p_pemail As Object, P_NRCONT As Object

    Public p_eapa As Long
    Public p_prc_compra As Integer
    Public p_rot1 As Object
    Public P_LIGAENCCX As Boolean
    Public P_VALCXFT As Boolean
    'Parametros Para Primavera
    Public p_provider As Object
    Public p_nomeserver As Object
    Public p_nomebd As Object
    Public p_usersql As Object
    Public p_passwsql As Object
    '

    '-----------------------------------
    Public PLAF(4) As Double
    Public nrcopias As String
    Public mopcao As Integer
    Public Xdadata As Date
    Public Xatedata As Date
    Public MSEQ As Long
    Public mvalordoc As Double
    Public mspid As Long
    Public VL(3)
    Public xdomod As String, xaomod As String, xdaest As String, xaoest As String
    Public OP_IMAGEM As Integer
    Public topmod As Long
    Public tem_reserva As Boolean
    Public multipack As String
    Public act_nremb As Long
    Public p_modelo As Object
    Public p_variante As Object
    Public Edit_Fact As Object
    Public Edit_Rec As Object
    Public passw As Object
    Public OpConvGR As Boolean

    Public FCLOSE As Boolean
    Public p_ligacad As Boolean
    Public P_TIPO_CAD As Long
    Public valida_pack As Boolean
    Public P_ACTPVPR As Integer
    Public op_plano As Integer
    Public PCopyREF As Boolean

    ' variaveis shoebiz
    Public SB_SERVICE_HOSTNAME As String
    Public ORIGEM As String
    Public USER_SB As String
    Public PASS_SB As String
    Public PASTA_CATFORN As String
    '
    Public p_captor As Boolean
    Public TipoPrcArt As Integer

    Public P_TIPO_DOCAUTO As Object
    Public P_RegClienteWeb As Boolean

    Public pcx_fam As String
    Public pcx_peca As String
    Public pcx_trata As Boolean

    Public pGrifo_fam As String
    Public pGrifo_peca As String
    Public pGrifo_trata As Boolean

    Public PEnco_Estado As Boolean
    Public PDebitaPortesQt As Double

    Public P_AT_USER As String, P_AT_USER_PASSWORD As String
    Public P_AT_ADI_TEMPO_TRANS As Long

    Public P_TIPO_NRCARTAO As Long
    Public P_TIPO_NRCARTAO_PK As Long
    Public P_AbateAutoOF As Boolean

    Public PARRAY_IVA(4, 4) As Object
    Public PTOTIVA As Double




    Public Function WebOficina()
        'DoCmd.Hourglass True
        'Application.FollowHyperlink "http://www.oficinasoftware.pt"
        'DoCmd.Hourglass False
    End Function
    Public Function valida_codpost(mcodpost As String) As String
        Dim myWinHTTP As WinHttp.WinHttpRequest
        myWinHTTP = New WinHttp.WinHttpRequest

        valida_codpost = ""
        On Error GoTo FIM

        myWinHTTP.Open("GET", "http://www.ctt.pt/pdcp/xml_pdcp?inCodPos=" & mcodpost, False)

        myWinHTTP.Send()
        Dim responseHeader As String
        responseHeader = myWinHTTP.GetAllResponseHeaders
        Dim responseText As String, localidade As String, X As String
        responseText = myWinHTTP.responseText
        i = InStr(1, responseText, "<CodPos>")
        If i = 0 Then
            valida_codpost = ""
            Exit Function
        End If
        j = InStr(i, responseText, "</CodPos>")
        localidade = Mid(responseText, i + 8, j - (i + 8))
        X = "<Designacao tipo=""O"">"
        i = InStr(1, localidade, X)
        j = InStr(i, localidade, "</Designacao>")
        valida_codpost = (Mid(localidade, i + Len(X), j - (i + Len(X))))
        '
FIM:

    End Function



    Public Function VALIDA_NIF(ByVal contrib As String) As Boolean

        Dim S As String
        S = contrib

        Dim c As String

        Dim i, checkDigit As Integer
        If Not IsNumeric(S) Then
            VALIDA_NIF = False
            GoTo FIM
        End If
        If (Len(S) <> 9) Then
            VALIDA_NIF = False
            GoTo FIM
        End If

        c = Mid(S, 1, 1)

        If (c = "1") Or (c = "2") Or (c = "5") Or (c = "6") Or (c = "8") Or (c = "9") Then

            checkDigit = Val(c) * 9

            For i = 2 To 8

                checkDigit = checkDigit + Val(Mid(S, i, 1)) * (10 - i)

            Next i

            checkDigit = 11 - (checkDigit Mod 11)

            If (checkDigit >= 10) Then checkDigit = 0

            If (checkDigit = Val(Mid(S, 9, 1))) Then
                VALIDA_NIF = True
                GoTo FIM
            End If

        End If

        VALIDA_NIF = False
FIM:
    End Function

    Public Function TVALOR_DOCFT(PID_NAME As String, ByRef XVALOR As Double, ByRef XDESCLN As Double, ByRef XQUANT As Double) As Double
        ' Calcula o VALOR DA VENDA

        Dim RST As New ADODB.Recordset

        If RST.State = adStateOpen Then
            RST.Close()
        End If
        RST.Open("SELECT SUM(VALORL) AS VALORL, SUM(DESCL) AS DESCL, SUM(QUANT) AS QUANT FROM dbo.WK_REGLIN WHERE ID_NAME = '" & PID_NAME & "'", cnn1, adOpenStatic, adLockReadOnly)
        If RST.EOF Then
            XVALOR = 0
            XDESCLN = 0
            XQUANT = 0
        Else
            XVALOR = Nz(RST.Fields("VALORL"), 0)
            XDESCLN = Nz(RST!DESCL, 0)
            XQUANT = Nz(RST!QUANT, 0)

        End If
        If RST.State = adStateOpen Then
            RST.Close()
        End If
    End Function

    Public Function CAL_VALOR_DOC(PFORM As Form, pvalor As Double, PDESCLN As Double, PQUANT As Double)
        Dim XDESCONTOS1 As Double
        Dim XDESCONTOS2 As Double
        Dim XDESCONTOS3 As Double

        XDESCONTOS1 = 0
        XDESCONTOS2 = 0
        XDESCONTOS3 = 0

        PFORM!NQUANT = PQUANT
        PFORM!mvalor = pvalor
        PFORM!TDESCLN = PDESCLN
        PFORM!subtot1 = pvalor - PDESCLN
        XDESCONTOS1 = 0
        XDESCONTOS2 = 0
        XDESCONTOS3 = 0
        XDESCONTOS1 = Nz(PFORM!subtot1, 0) * (Nz(PFORM!DESC1, 0) / 100)
        XDESCONTOS2 = (Nz(PFORM!subtot1, 0) - Nz(XDESCONTOS1)) * IIf(Nz(PFORM!DESC2, 0) > 0, (Nz(PFORM!DESC2, 0) / 100), 0)
        XDESCONTOS3 = (Nz(PFORM!subtot1, 0) - Nz(XDESCONTOS1) - Nz(XDESCONTOS2)) * IIf(Nz(PFORM!DESC3, 0) > 0, (Nz(PFORM!DESC3, 0) / 100), 0)
        PFORM!Descontos = C_RND(Nz(XDESCONTOS1) + Nz(XDESCONTOS2) + Nz(XDESCONTOS3), PFORM!DECIMAIS)
        PFORM!NVALLIQ = pvalor - Nz(PFORM!Descontos, 0) - PDESCLN

        Select Case PFORM.Name
            Case "DOC_FACT"
                PTOTIVA = 0
                Call TRATA_IVA("", 0, PFORM!id_name, "WK_REGLIN", P_TaxRegion, PFORM!TXIVA, Nz(PFORM!Descontos, 0), 0, PARRAY_IVA(), PTOTIVA)
                PFORM!NIVA = PTOTIVA
            Case Else
                PFORM!NIVA = C_RND(PFORM!NVALLIQ * PFORM!TXIVA / 100, PFORM!DECIMAIS)
        End Select

        PFORM!NTOTAL = PFORM!NVALLIQ + PFORM!NIVA


    End Function

    Public Function WRITE_MSG(ptipo As String, PPARTNER As String, PTIPOMSG As String, ptitulo As String, pdocref As String, PID_TRANS As String) As Boolean
        WRITE_MSG = False
        Dim SB_MENSAGENS As New ADODB.Recordset
        SB_MENSAGENS.Open("SELECT * FROM SB_MENSAGENS WHERE NRREG IS NULL", cnn1, adOpenStatic)
        With SB_MENSAGENS
            .AddNew()
            !TIPO = ptipo
            !partner_id = PPARTNER
            !tipo_msg = PTIPOMSG
            !TITULO = ptitulo
            !DOCREF = pdocref
            !id_transaction = PID_TRANS
            .UpdateBatch()
        End With
        WRITE_MSG = True
        If SB_MENSAGENS.State = adStateOpen Then
            SB_MENSAGENS.Close()
        End If
        Exit Function
ERR:
        MsgBox(Err.Number & " " & Err.Description)
FIM:
    End Function

    Public Function FDATA(PFILTRO As String) As String
        Dim XFILTRO As String
        Dim I1 As Long, I2 As Long, p As Long, m As Long, D As Long, a As Long
        Dim DT As String, DTT As String, dif As Long
        Dim DT1 As Date, Ano As Long, Mes As Long, DIA As Long
        XFILTRO = PFILTRO
        p = 1
        Do While True
            I1 = InStr(p, XFILTRO, "#", vbTextCompare)
            If I1 = 0 Then
                Exit Do
            End If
            I2 = InStr(1, Mid(XFILTRO, I1 + 1, 300), "#", vbTextCompare)
            DT = Mid(XFILTRO, I1 + 1, (I2 - 1))
            m = InStr(1, DT, "/")
            Mes = Val(Mid(DT, 1, m - 1))
            D = InStr(m + 1, DT, "/")
            DIA = Val(Mid(DT, m + 1, D - m))
            Ano = Val(Mid(DT, D + 1, 4))
            DT1 = CDate(strzero(DIA, 2) & "-" & strzero(Mes, 2) & "-" & strzero(Ano, 4))

            DTT = Format(DT1, "DD-MM-YYYY")
            dif = Len(DTT) - Len(DT)
            XFILTRO = Replace(XFILTRO, DT, DTT, 1)
            p = I1 + I2 + dif + 1
        Loop
        XFILTRO = Replace(XFILTRO, "#", "'", 1)
        XFILTRO = Replace(XFILTRO, "#", "'", 1)
        FDATA = Nz(XFILTRO, "")
    End Function
    Public Function FDATA_rel(PFILTRO As String) As String
        Dim XFILTRO As String
        Dim I1 As Long, I2 As Long, p As Long, m As Long, D As Long, a As Long
        Dim DT As String, DTT As String, dif As Long
        Dim DT1 As Date, Ano As Long, Mes As Long, DIA As Long
        XFILTRO = PFILTRO
        p = 1
        Do While True
            I1 = InStr(p, XFILTRO, "#", vbTextCompare)
            If I1 = 0 Then
                Exit Do
            End If
            I2 = InStr(1, Mid(XFILTRO, I1 + 1, 300), "#", vbTextCompare)
            DT = Mid(XFILTRO, I1 + 1, (I2 - 1))
            m = InStr(1, DT, "/")
            Mes = Val(Mid(DT, 1, m - 1))
            D = InStr(m + 1, DT, "/")
            DIA = Val(Mid(DT, m + 1, D - m))
            Ano = Val(Mid(DT, D + 1, 4))
            DT1 = CDate(strzero(DIA, 2) & "-" & strzero(Mes, 2) & "-" & strzero(Ano, 4))

            DTT = Format(DT1, "mm-dd-YYYY")

            dif = Len(DTT) - Len(DT)
            XFILTRO = Replace(XFILTRO, DT, DTT, 1)
            p = I1 + I2 + dif + 1
        Loop
        XFILTRO = Replace(XFILTRO, "#", "'", 1)
        XFILTRO = Replace(XFILTRO, "#", "'", 1)
        FDATA_rel = Nz(XFILTRO, "")
    End Function






    Public Function TesteSQL()
        Dim cnn As ADODB.Connection
        cnn = New ADODB.Connection
        On Error GoTo errsql
        If cnn.State = adStateOpen Then
            cnn.Close()
        End If
        With cnn
            .Provider = p_provider
            .Properties("Data Source").Value = p_nomeserver
            .Properties("Initial Catalog").Value = p_nomebd
            .Properties("User Id") = p_usersql
            If Not IsNull(p_passwsql) Then
                .Properties("password") = p_passwsql
            End If
            .Open()
        End With
        GoTo okk
errsql:
        MsgBox("erro de conexão á base de dados..." _
            , vbOKOnly + vbCritical, "Testar origem de Dados")

        'MsgBox Err.Number & vbCrLf & Err.Description

        GoTo FIM
okk:
        MsgBox("OS TESTES FORAM CONCLUÍDOS COM ÊXITO!", vbExclamation, "Testar origem de Dados")
FIM:

    End Function


    Public Function ID_PROC()
        Dim IDPROC As ADODB.Recordset
        IDPROC = New ADODB.Recordset

        IDPROC.Open("SELECT IDproc from IDPROC", cnn1, adOpenStatic, adLockOptimistic)
        mspid = IDPROC!idproc
    End Function
    Public Function strFILL(pstr As Object, plen As Integer) As String
        Dim Y As String
        Dim l, L1 As Integer
        If IsNull(pstr) Then
            strFILL = Space(plen)
            GoTo FIM
        End If
        Y = Trim((pstr))
        l = Len(Y)
        L1 = plen - l
        If L1 > 0 Then
            strFILL = pstr & Space(L1)
        Else
            strFILL = Mid(pstr, 1, plen)
        End If
FIM:
    End Function
    Public Function csepdec(ByVal XVALOR As Double) As String
        Dim str As String
        Dim POS As Integer
        str = CStr(XVALOR)
        If str = "" Then
            csepdec = "0"
            Exit Function
        End If
        POS = InStr(1, str, ",", vbTextCompare)
        If POS <> 0 Then
            Mid(str, POS, 1) = "."
        End If
        csepdec = str
    End Function
    Public Function csepdec2(ByVal XVALOR As Double) As String
        Dim str As String
        Dim POS As Integer
        str = Format(XVALOR, "#0.00")
        If str = "" Then
            csepdec2 = "0.00"
            Exit Function
        End If
        POS = InStr(1, str, ",", vbTextCompare)
        If POS <> 0 Then
            Mid(str, POS, 1) = "."
        End If
        csepdec2 = str
    End Function

    Public Function inicio()
        Dim PARAM As ADODB.Recordset
        Dim PARAM_SAFT As New ADODB.Recordset

        cnn1 = New ADODB.Connection
        cnn2 = New ADODB.Connection

        On Error GoTo ligar
        cnn1 = CurrentProject.Connection
        GoTo siga
ligar:
        DoCmd.OpenForm("ligacao_sql", , , , , acDialog)
        cnn1 = CurrentProject.Connection
siga:
        cnn2 = CurrentProject.Connection
        cnn1.Execute "SET DATEFORMAT DMY"
        cnn2.Execute "SET DATEFORMAT DMY"

        PARAM = New ADODB.Recordset
        PARAM.Open("select * from param", cnn1, adOpenStatic, adLockReadOnly)

        PARAM.MoveFirst()

        If Not (CHAVE(PARAM!EMPRESA) = PARAM!CHAVE) Or IsNull(PARAM!CHAVE) Then

            MsgBox("Giic não licenciado." & Chr(13) & _
            "Por favor contacte a Oficina de Soluções 256 832547." _
            , vbOKOnly + vbCritical, "Licenciamento")
            DoCmd.Quit()
        End If


        If IsNull(PARAM!PISENTOIVA_INTER) Or IsNull(PARAM!PISENTOIVA_EXTRA) Then
            MsgBox("Parâmetros de isenção do IVA Obrigatório... ", vbOKOnly + vbCritical)
            DoCmd.Quit()
        End If


        If Not TestDecimal() Then
            MsgBox("ATENÇÃO: As suas definições regionais não se encontram no estado requerido pelo programa! Por favor altere-as. Ex 1.000,00", vbOKOnly + vbCritical)
            DoCmd.Quit()
        End If


        P_VersaoSQL = Nz(PARAM!PVersaoSQL, "sql2000")
        p_EmpCertificada = Nz(PARAM!EmpCertificada, True)
        p_empresa = PARAM!EMPRESA
        p_marca = PARAM!MARCA
        p_ptelef = PARAM!PTELEF
        p_pfax = PARAM!PFAX
        p_pemail = PARAM!PEMAIL
        P_NRCONT = PARAM!PNRCONT

        P_DIRMAPAS = PARAM!PDIRMAPAS
        P_DirImportEnco = PARAM!DirImportEnco
        p_ImportEncoExcel = PARAM!ImportEncoExcel
        P_DirSaft = PARAM!DirSaft
        p_arm = PARAM!PARM
        p_armPa = PARAM("PARMPA").Value
        P_MultiIVA = Nz(PARAM!PMultiIVA, False)
        P_TXIVA = PARAM!PTXIVA
        P_TaxRegion = Nz(PARAM!PTaxRegion, "PT")
        P_ISENTOIVA_INTER = PARAM!PISENTOIVA_INTER
        P_ISENTOIVA_EXTRA = PARAM!PISENTOIVA_EXTRA
        p_moeda = PARAM!PMOEDA
        p_internacional = PARAM!INTERNACIONAL
        p_lingua = PARAM!lingua
        p_ligacc = PARAM!LIGACC
        p_ctrlplafond = Nz(PARAM!CTRL_PLAFOND, 1)
        plafond_ok = True
        plafond_atrib = 0
        p_passplaf = PARAM!PPASSPLAF
        p_passSAFT = PARAM!PassSAFT
        p_aplicacao_cc = PARAM!APLICACAO_CC
        P_IMPRIMELOGO = PARAM!IMPRIMELOGO
        P_LOCAL_EMISSAO = PARAM!PLOCAL_EMISSAO
        p_ConfVar = Nz(PARAM!ConfVar, 1)
        p_desc1 = PARAM!PDESC1
        p_desc2 = PARAM!PDESC2
        p_desc3 = PARAM!PDESC3
        p_desc4 = PARAM!PDESC4
        p_desc5 = PARAM!PDESC5
        p_desc_i1 = PARAM!PDESC_I1
        p_desc_i2 = PARAM!PDESC_I2
        p_desc_i3 = PARAM!PDESC_I3
        p_desc_i4 = PARAM!PDESC_I4
        p_desc_i5 = PARAM!PDESC_I5
        p_desc_F1 = PARAM!PDESC_F1
        p_desc_F2 = PARAM!PDESC_F2
        p_desc_F3 = PARAM!PDESC_F3
        p_desc_F4 = PARAM!PDESC_F4
        p_desc_F5 = PARAM!PDESC_F5
        P_DESCORC1 = PARAM!PDESCORC1
        P_DESCORC2 = PARAM!PDESCORC2
        P_DESCORC3 = PARAM!PDESCORC3
        P_DESCORC4 = PARAM!PDESCORC4
        P_DESCORC5 = PARAM!PDESCORC5
        P_DESCORC6 = PARAM!PDESCORC6
        P_DESCORC7 = PARAM!PDESCORC7

        P_GGF = PARAM!PGGF
        P_MARGMP = PARAM!PMARGMP
        P_MARGMO = PARAM!PMARGMO
        P_MARGVND = PARAM!PMARGVND
        P_COMISSAO = PARAM!PCOMISSAO
        P_CUSTFIN = PARAM!PCUSTFIN
        P_RETORNO = PARAM!PRETORNO

        P_CopiaPRC = Nz(PARAM!CopiaPRC, False)
        P_AltTempoRota = Nz(PARAM("AltTempoRota"), False)

        p_ferramenta = PARAM!PFERRAMENTA
        p_ftec = PARAM!PFTEC
        p_forc = PARAM!PFORC
        P_PRCSTD = PARAM!pprcstd
        p_desccom = PARAM!PDESCCOM
        p_opdesc = PARAM!POPDESC
        p_encoauto = PARAM!PENCOAUTO
        nova_encomenda = False
        p_necmat1 = PARAM!PNECMAT1
        p_necmat2 = PARAM!PNECMAT2
        p_necmat3 = PARAM!PNECMAT3
        P_DATACC = PARAM!PDATACC
P_DATACC_FECHO = Nz(PARAM!PDATACC_FECHO, Date - 365)
        P_RESERVA_PA = PARAM!RESERVA_PA
        P_VPN = PARAM!VPN
        p_convgr = PARAM!PCONVGR
        p_expetiq = PARAM!PExpEtiq
        P_DIRFOTO = PARAM!DIRFOTO
        P_DIRFOTOART = PARAM!DIRFOTOART
        P_EXTFOTO = PARAM!EXTFOTO
        P_ValidarStocks = PARAM!ValidarStocks
        P_DadosEnco = Nz(PARAM!DadosEnco, False)
        p_ligacad = Nz(PARAM!PLIGACAD, False)
        P_TIPO_CAD = Nz(PARAM!PTIPO_CAD, 1)
        p_eapa = PARAM!PEAPA
        p_prc_compra = PARAM!PRC_COMPRA
        p_rot1 = PARAM!PROT1
        P_LIGAENCCX = Nz(PARAM!PLIGAENCCX, True)
        P_VALCXFT = Nz(PARAM!PVALCXFT, False)
        P_RegPrepack = Nz(PARAM!PRegPrePack, False)
        P_QtSort = Nz(PARAM!PQTSORT, 10)
        p_dtfechostk = PARAM.Fields("DTFechoSTK").Value

        '
        p_captor = PARAM!PCAPTOR

        p_provider = PARAM!PROVIDERSQL
        p_nomeserver = PARAM!NOMESERVER
        p_nomebd = PARAM!NOMEBD
        p_usersql = PARAM!USERSQL
        p_passwsql = PARAM!PASSWSQL
        '
        P_ACTPVPR = Nz(PARAM!PACTPVPR, 0)
        '
        SB_SERVICE_HOSTNAME = Nz(PARAM!SB_SERVICE_HOSTNAME, "")
        ORIGEM = Nz(PARAM!SB_PARTYID, "")
        USER_SB = Nz(PARAM!SB_USERNAME, "")
        PASS_SB = Nz(PARAM!SB_PASSWORD, "")
        PASTA_CATFORN = Nz(PARAM!SB_PASTA_CATFORN, "")
        '
        P_LigaEmpresa = Nz(PARAM!LigaEmpresa, False)
        P_TipoPrecoEsp = Nz(PARAM!TipoPrecoEsp, 1)
        P_TipoBD = Nz(PARAM!TipoBD, 1)
        P_GestaoSALTOS = Nz(PARAM!GestaoSALTOS, False)
        P_TipoFT_SA = Nz(PARAM!TipoFT_SA, 1)
        P_ValidaModCli = Nz(PARAM!ValidaModCli, False)
        P_VerPrc2EC = Nz(PARAM!VerPrc2EC, False)
        p_GeraAutoEAN = Nz(PARAM!GeraAutoEAN, True)
        P_TIPO_DOCAUTO = PARAM!PTIPO_DOCAUTO
        P_RegClienteWeb = Nz(PARAM!RegClienteWeb, False)

        pcx_fam = Nz(PARAM!CX_FAM, "")
        pcx_peca = Nz(PARAM!CX_PECA, "")
        pcx_trata = Nz(PARAM!CX_TRATA, False)

        pGrifo_fam = Nz(PARAM!GRIFO_FAM, "")
        pGrifo_peca = Nz(PARAM!GRIFO_PECA, "")
        pGrifo_trata = Nz(PARAM!GRIFO_TRATA, False)

        PEnco_Estado = Nz(PARAM!ENCO_ESTADO, True)
        PDebitaPortesQt = Nz(PARAM!DEBITA_PORTES_QT, 0)

        P_AT_USER = Nz(PARAM!AT_USER, "")
        P_AT_USER_PASSWORD = Nz(PARAM!AT_USER_PASSWORD, "")
        P_AT_ADI_TEMPO_TRANS = Nz(PARAM!AT_ADI_TEMPO_TRANS, 15)

        P_TIPO_NRCARTAO = Nz(PARAM!TIPO_NRCARTAO, 1)
        P_TIPO_NRCARTAO_PK = Nz(PARAM!TIPO_NRCARTAO_PK, 1)
        P_AbateAutoOF = Nz(PARAM.Fields("AbateAutoOF"), True)


        PTIMEOUT = 0

        If PARAM.State = adStateOpen Then
            PARAM.Close()
        End If



        '--------------------------------
        If PARAM_SAFT.State = adStateOpen Then
            PARAM_SAFT.Close()
        End If

        PARAM_SAFT.Open("select * from param_SAFT", cnn1, adOpenStatic, adLockReadOnly, adCmdText)
        If Not PARAM_SAFT.EOF Then
            PARAM_SAFT.MoveFirst()
            P_VersaoChave = Nz(PARAM_SAFT!VerChave, 0)
            P_ProductId = Nz(PARAM_SAFT!ProductId, "")
            P_ProductVersion = Nz(PARAM_SAFT!ProductVersion, "")
            P_ProductCertificationNumber = Nz(PARAM_SAFT!ProductCertificationNumber, "")
        Else
            P_VersaoChave = 0
            P_ProductId = ""
            P_ProductVersion = ""
            P_ProductCertificationNumber = ""
        End If

        If PARAM_SAFT.State = adStateOpen Then
            PARAM_SAFT.Close()
        End If
        '-----------------------------------




        cnn1.CommandTimeout = PTIMEOUT
        cnn2.CommandTimeout = PTIMEOUT

    End Function


    Public Function test() As Boolean



        If Dir("c:\windows\system\wansys.com") = "" Then
            test = False
        Else
            test = True
            GoTo siga
        End If

        If Dir("c:\winnt\system32\wansys.com") = "" Then
            test = False
        Else
            test = True
        End If


        If test = False Then
            MsgBox("Win Giic não licenciado" & Chr(13) & _
           "Contacte a Oficina de Soluções 256 832547")
        End If

siga:



        'With Application.FileSearch
        '.NewSearch
        '.LookIn = "c:\windows\system\"
        '.FileName = "wansys.com"
        '.Execute
        'If .Execute() > 0 Then
        'test = True
        'Else
        ' .NewSearch
        '.LookIn = "c:\winnt\system32\"
        '.FileName = "wansys.com"
        '.Execute
        'If .Execute() > 0 Then
        'test = True
        'Else
        'test = False
        'MsgBox ("Win Giic não licenciado" & Chr(13) & _
        "Contacte a Oficina de Soluções 256 832547")
        'End If
        'End If
        'End With
    End Function
    Public Function TestHasp() As Boolean

        TestHasp = True

        '----------------------------
        If NetLogin() = False Then
            TestHasp = False
            MsgBox("Win Giic não licenciado  hasp login" & Chr(13) & _
            "Contacte a Oficina de Soluções 256 832547")
        End If
        If GetNetID() = False Then
            TestHasp = False
            MsgBox("Win Giic não licenciado hasp net id" & Chr(13) & _
                "Contacte a Oficina de Soluções 256 832547")
        End If
        '---------------------------------


    End Function



    Public Function AUTORIZA(PGRUPO As String, PFORM As String) As Boolean
        'Dim DB As Database
        Dim INTERDICOES As ADODB.Recordset
        INTERDICOES = New ADODB.Recordset
        Dim STRSQL As String
        STRSQL = "select * from interdicoes where "
        STRSQL = STRSQL & "grupo = '" & PGRUPO & "' and formulario = '" & PFORM & "'"
        
        INTERDICOES.Open(STRSQL, cnn1, adOpenStatic, adLockReadOnly, adCmdText)

        If INTERDICOES.EOF Then
            P_ABRIR = True
            P_NOVO = True
            P_EDIT = True
            P_DEL = True
        Else
            Select Case INTERDICOES!ABRIR
                Case False
                    P_ABRIR = False
                    P_NOVO = False
                    P_EDIT = False
                    P_DEL = False
                Case True
                    P_ABRIR = True
                    P_NOVO = True
                    P_EDIT = True
                    P_DEL = True

                    If INTERDICOES!NOVO = True Then
                        P_NOVO = True
                    Else
                        P_NOVO = False
                    End If
                    If INTERDICOES!EDITAR = True Then
                        P_EDIT = True
                    Else
                        P_EDIT = False
                    End If
                    If INTERDICOES("Apagar").Value = True Then
                        P_DEL = True
                    Else
                        P_DEL = False
                    End If
            End Select
        End If
        AUTORIZA = True
        INTERDICOES.Close()
        INTERDICOES = Nothing
    End Function

    Public Function C_RND(pnum As Object, dec As Integer) As Double
        C_RND = 
    End Function

    Public Function dvnc(xcnd As String, XDATA As Date) As Date
        '* calculo da data de vencimento

        Dim DIA As String, Mes As String, Ano As String, DDATA As Date
        Dim TABPAG As Recordset
        Dim MXDATA As Date
        
        TABPAG = New ADODB.Recordset
        MXDATA = XDATA
        'tabpag.Seek "=", xcnd
        TABPAG.Open("select * from tabpag where cndpag = '" & xcnd & "'", cnn1, adOpenStatic, adLockReadOnly)
        If TABPAG.EOF Then
dvnc = Date
            GoTo FIM
        End If
        Select Case TABPAG!DIAINI
            Case "1"
                DDATA = MXDATA + Nz(TABPAG!NRDIAS, 0)
            Case "2"
                If Month(MXDATA) = 12 Then
                    MXDATA = CDate(Str(Year(MXDATA) + 1) & "-01-01")
                Else
                    MXDATA = CDate(Str(Year(MXDATA)) & "-" & strzero(Month(MXDATA) + 1, 2) & "-01")
                End If
                DDATA = MXDATA + TABPAG!NRDIAS
            Case Else
                DDATA = MXDATA
        End Select
        Ano = Str(Year(DDATA)) & "-"
        Mes = strzero(Month(DDATA), 2) & "-"
        DIA = strzero(Day(DDATA), 2)
        If Nz(TABPAG!DIAPAG) > 0 Then
            DIA = strzero(TABPAG!DIAPAG, 2)
        End If
        If Mes = "02-" Then
            If DIA > "28" Then
                If Year(DDATA) Mod 4 = 0 Then
                    DIA = "29"
                Else
                    DIA = "28"
                End If
            End If
        End If
        If Mes = "04-" Or Mes = "06-" Or Mes = "09-" Or Mes = "11-" Then
            If DIA = "31" Then
                DIA = "30"
            End If
        End If
        '
        Select Case Nz(TABPAG!DIAPAG)
            Case Is > 0
                If TABPAG!SENTIDO = "+" Then
                    If Day(DDATA) < TABPAG!DIAPAG Then
                        dvnc = CDate(Ano & Mes & DIA)
                    Else
                        ' prox mes
                        If Mes = "12-" Then
                            dvnc = CDate(Str(Year(DDATA) + 1) & "-" & "01-" & DIA)
                        Else
                            '''
                            If CLng(Month(DDATA) + 1) = 2 Then
                                If DIA > "28" Then
                                    If Ano Mod 4 = 0 Then
                                        DIA = "29"
                                    Else
                                        DIA = "28"
                                    End If
                                End If
                            End If
                            '''
                            If CLng(Month(DDATA) + 1) = 4 Or CLng(Month(DDATA) + 1) = 6 Or CLng(Month(DDATA) + 1) = 9 Or CLng(Month(DDATA) + 1) = 11 Then
                                If DIA = "31" Then
                                    DIA = "30"
                                End If
                            End If

                            dvnc = CDate(Ano & strzero(CLng(Month(DDATA)) + 1, 2) & "-" & DIA)
                        End If
                    End If
                Else
                    ' sentido -  andar para tras
                    '*
                    If Day(DDATA) > TABPAG!DIAPAG Then
                        dvnc = CDate(Ano & Mes & DIA)
                    Else
                        '  mes anterior
                        If Mes = "01-" Then
                            dvnc = CDate(Str(Year(DDATA) - 1) & "-" & "12" & "-" & DIA)
                        Else
                            If CLng(Month(DDATA) - 1) = 2 Then
                                If DIA > "28" Then
                                    If Ano Mod 4 = 0 Then
                                        DIA = "29"
                                    Else
                                        DIA = "28"
                                    End If
                                End If
                            End If
                            '''
                            If CLng(Month(DDATA) - 1) = 4 Or CLng(Month(DDATA) - 1) = 6 Or CLng(Month(DDATA) - 1) = 9 Or CLng(Month(DDATA) - 1) = 11 Then
                                If DIA = "31" Then
                                    DIA = "30"
                                End If
                            End If



                            dvnc = CDate(Ano & strzero(CLng(Month(DDATA)) - 1, 2) & "-" & DIA)
                        End If


                    End If

                End If
            Case Else
                dvnc = DDATA
        End Select
FIM:
        TABPAG.Close()
    End Function

    Public Function strzero(pnum As Long, plen As Integer) As String
        Dim X, Y As String
        Dim l, L1 As Integer

        X = "00000000000000000000"
        Y = LTrim(Str(pnum))
        l = Len(Y)
        L1 = plen - l
        If L1 > 0 Then
            strzero = Mid(X, 1, L1) & Y
        Else
            strzero = Y
        End If

    End Function

    Public Function ccambios(PMOE1 As Object) As Double
        Dim tabmoe As New ADODB.Recordset

        If tabmoe.State = adStateOpen Then
            tabmoe.Close()
        End If

        tabmoe.Open("select * from tabeuro where moeda = '" & PMOE1 & "'", cnn1, adOpenStatic, adLockReadOnly)
        If tabmoe.EOF Then
            ccambios = 1
        Else
            ccambios = Nz(tabmoe!factor, 1)
        End If

        If tabmoe.State = adStateOpen Then
            tabmoe.Close()
        End If
    End Function

    Function EnableControls(FRM As Form, intSection As Integer, intState As Boolean) As Boolean

        '  Enable or disable controls in specified section of form.
        '  Use the Form object, section constant and state arguments
        '  passed to the EnableControls procedure.

        Dim ctl As control

        '  Set intState for all controls in specified section.
        For Each ctl In FRM.Controls
            If ctl.Section = intSection Then
                On Error Resume Next
                ctl.Locked = intState
                Err = 0
            End If
        Next ctl

        EnableControls = True

    End Function


    Public Function IsLoaded(strFrmName As String) As Boolean

        '  Determines if a form is loaded.

        Const conFormDesign = 0
        Dim intx As Integer

        IsLoaded = False
        For intx = 0 To Forms.Count - 1
            If Forms(intx).FormName = strFrmName Then
                If Forms(intx).CurrentView <> conFormDesign Then
                    IsLoaded = True
                    Exit Function  ' Quit function once form has been found.
                End If
            End If
        Next

    End Function

    Public Function fileexist(pDir As String, pnome As String) As Boolean

        With Application.FileSearch
            .NewSearch()
            .LookIn = pDir
            .filename = pnome
            .MatchTextExactly = True
            .Execute()
            If .Execute() > 0 Then
                fileexist = True
            Else
                fileexist = False
            End If
        End With
    End Function

Function loc_foto(MODELO As String, var As String, Optional loc_imag As Variant) As String
        ' Nova versão : campo imagem
        'Dim DBA As Database
        Dim RST As ADODB.Recordset
        'Set DBA = OpenDatabase(diravent)
        RST = New ADODB.Recordset
        RST.Open("select * from param", cnn2, adOpenStatic, adLockOptimistic, adCmdText)

        If IsNull(loc_imag) Or (loc_imag) = "" Then
            RST.MoveFirst()
            loc_foto = Trim(RST!DIRFOTO) & Trim(MODELO) & "." & Trim(RST!EXTFOTO)
        Else
            loc_foto = Trim(loc_imag)
        End If
        RST.Close()
        RST = Nothing
    End Function

    Public Function CMB(pvalor As Double, PMOE1 As Object, PMOE2 As Object) As Double
        ' CAMBIOS DE PTE OU EUR PARA OUTRAS MOEDAS
        'Dim DB As Database
        Dim tabmoe As ADODB.Recordset
        tabmoe = New ADODB.Recordset
        Dim INTER As Double

        'Set DB = OpenDatabase(DIRECTORIO)
        'Set tabmoe = db.OpenRecordset("TABEURO")
        'tabmoe.Index = "Primarykey"
        '
        If IsNull(PMOE1) Or IsNull(PMOE2) Or pvalor = 0 Then
            CMB = 0
            GoTo FIM
        End If
        tabmoe.Open("select * from tabeuro where moeda ='" & PMOE2 & "'", cnn1, adOpenStatic, adLockReadOnly)
        'tabmoe.Seek "=", PMOE2
        If tabmoe.EOF Then
            CMB = 0
            GoTo FIM
        End If
        If PMOE1 = "EUR" Then
            CMB = C_RND(pvalor * Nz(tabmoe!FACTOR, 1), tabmoe!DECIMAIS)
            GoTo FIM
        End If
        If PMOE1 = "PTE" Then
            'If tabmoe!UEM = True Then
            'CMB = c_rnd(pvalor / tabmoe!FACTOR, tabmoe!DECIMAIS)
            'GoTo fim
            'End If
            CMB = C_RND(pvalor / 200.482, 2)
            CMB = C_RND(CMB * tabmoe!FACTOR, tabmoe!DECIMAIS)
        End If
FIM:
        If tabmoe.State = adStateOpen Then
            tabmoe.Close()
        End If
    End Function
    Public Function configura()
        ' tradução de menus' ver o comando find???
        Dim ctl As Object, obj1 As control, Ctl1 As Object, Ctl2 As Object, Ctl3 As Object
        Dim Ctl4 As Object, Ctl5 As Object, Ctl6 As Object, Ctl7 As Object, Ctl8 As Object
        Dim TEXTO As String, txt As String

        With Application.CommandBars
            For Each ctl In Application.CommandBars("WinGiic").Controls
                '  MsgBox (ctl.Caption & "  " & ctl.Type)
                TEXTO = ctl.Tag
                Call write_dic(ctl, TEXTO, txt)
                Ctl1 = ctl.commandbar
                'MsgBox (ctl1.Type)

                For Each Ctl2 In Ctl1.Controls
                    'MsgBox (ctl2.Caption & "  " & ctl2.Type)
                    TEXTO = Ctl2.Tag
                    Call write_dic(Ctl2, TEXTO, txt)
                    If Ctl2.Type = 10 Then
                        Ctl3 = Ctl2.commandbar
                        For Each Ctl4 In Ctl3.Controls
                            'MsgBox (ctl4.Caption & "  " & ctl4.Type)
                            TEXTO = Ctl4.Tag
                            Call write_dic(Ctl4, TEXTO, txt)

                            If Ctl4.Type = 10 Then
                                Ctl5 = Ctl4.commandbar
                                For Each Ctl6 In Ctl5.Controls
                                    ' MsgBox (ctl6.Caption & "  " & ctl6.Type)
                                    TEXTO = Ctl6.Tag
                                    Call write_dic(Ctl6, TEXTO, txt)

                                    If Ctl6.Type = 10 Then
                                        Ctl7 = Ctl6.commandbar
                                        For Each Ctl8 In Ctl7.Controls
                                            'MsgBox (ctl8.Caption & "  " & ctl8.Type)
                                            TEXTO = Ctl8.Tag
                                            Call write_dic(Ctl8, TEXTO, txt)

                                        Next Ctl8
                                    End If
                                Next Ctl6
                            End If

                        Next Ctl4
                    End If
                Next Ctl2
            Next ctl
        End With

FIM:
    End Function

    Public Function traduz(FRM As Form, plingua As Long)
        'Dim db As Database
        Dim dicionario As ADODB.Recordset
        Dim txt As String
        Dim TEXTO As String
        Dim pge As Page
        Dim frm2 As Form
        Dim nomesubform As String, nomesubform1 As String, nomesubform2 As String
        Dim i As Long
        Dim ctl As control, Ctl1 As control, Ctl2 As control, Ctl3 As control, Ctl4 As control, Ctl5 As control
        Dim INTI As Integer, intCanEdit As Integer
        Select Case plingua
            Case 0
                txt = "NATIVO"
                '    GoTo fim
            Case 1
                txt = "INGLES"
            Case 2
                txt = "FRANCES"
            Case 3
                txt = "ESPANHOL"
            Case 4
                txt = "ALEMAO"
        End Select
        'Set db = OpenDatabase(DIRECTORIO)
        'Set dicionario = db.OpenRecordset("dicionario")
        'dicionario.Index = "primarykey"
        dicionario = New ADODB.Recordset
        For Each ctl In FRM.Controls
            With ctl
                If ctl.Visible = True Then
                    Select Case .ControlType
                        Case acLabel, acCommandButton
                            TEXTO = .Caption
                            'dicionario.Seek "=", texto
                            If dicionario.State = adStateOpen Then
                                dicionario.Close()
                            End If

                            dicionario.Open("select * from dicionario where nativo = '" & TEXTO & "'", cnn1, adOpenStatic, adLockOptimistic)
                            If Not dicionario.EOF Then
                                If Not IsNull(dicionario(txt)) Then
                                    .Caption = dicionario(txt)
                                End If
                            Else
                                If p_lingua = 0 Then
                                    dicionario.AddNew()
                                    dicionario!NATIVO = TEXTO
                                    dicionario.Update()
                                End If
                            End If

                            '               Call write_dic2(ctl, texto, txt)
                        Case acSubform
                            nomesubform1 = .Name
                            'nomesubform1 = .SourceObject
                            '          MsgBox (frm.Form(nomesubform1).Controls.Count)
                            For Each Ctl3 In FRM.Form(nomesubform1).Controls
                                With Ctl3
                                    Select Case Ctl3.ControlType
                                        Case acLabel, acCommandButton
                                            TEXTO = .Caption
                                            '        MsgBox (.Caption)
                                            Call write_dic2(Ctl3, TEXTO, txt, plingua)
                                    End Select
                                End With
                            Next
                        Case acTabCtl
                            For i = 0 To .Pages.Count - 1
                                pge = .Pages(i)
                                TEXTO = pge.Caption
                                Call write_dic2(pge, TEXTO, txt, plingua)
                                '              MsgBox (pge.Caption)
                                For Each Ctl4 In pge.Controls
                                    With Ctl4
                                        If Ctl4.Visible = True Then
                                            Select Case .ControlType
                                                '       Case acSubform
                                                'nomesubform2 = .SourceObject
                                                'MsgBox (ctl3.Form(nomesubform2).Controls.Count)
                                                'For Each ctl5 In frm.Form(nomesubform1).Form(nomesubform2).Controls
                                                'With ctl5
                                                'Select Case ctl5.ControlType
                                                'Case acLabel, acCommandButton
                                                'texto = .Caption
                                                'MsgBox (.Caption)
                                                'Call write_dic(ctl5, texto, txt)
                                                'End Select
                                                'End With
                                                'Next
                                                Case acLabel, acCommandButton
                                                    TEXTO = .Caption
                                                    '      MsgBox (.Caption)
                                                    Call write_dic2(Ctl4, TEXTO, txt, plingua)
                                            End Select
                                        End If
                                    End With
                                Next

                            Next i


                        Case acTabCtl
                            For i = 0 To .Pages.Count - 1
                                pge = .Pages(i)
                                TEXTO = pge.Caption
                                Call write_dic2(pge, TEXTO, txt, plingua)
                                For Each Ctl1 In pge.Controls
                                    With Ctl1
                                        '  MsgBox (pge.Controls(0).Name)
                                        ' MsgBox (pge.Controls.Count - 1)
                                        If Ctl1.Visible = True Then
                                            Select Case .ControlType
                                                Case acSubform
                                                    nomesubform = .SourceObject
                                                    '    MsgBox (frm.Form(nomesubform).Controls.Count)
                                                    For Each Ctl2 In FRM.Form(nomesubform).Controls
                                                        With Ctl2
                                                            Select Case Ctl2.ControlType
                                                                Case acLabel, acCommandButton
                                                                    TEXTO = .Caption
                                                                    '   MsgBox (.Caption)
                                                                    Call write_dic2(Ctl2, TEXTO, txt, plingua)
                                                            End Select
                                                        End With
                                                    Next
                                                Case acLabel, acCommandButton
                                                    TEXTO = .Caption
                                                    '  MsgBox (.Caption)
                                                    Call write_dic2(Ctl1, TEXTO, txt, plingua)
                                            End Select
                                        End If
                                    End With
                                Next


                            Next i
                        Case Else
                            GoTo siga
                    End Select
                End If
            End With
siga:
        Next
FIM:
        If dicionario.State = adStateOpen Then
            dicionario.Close()
        End If
    End Function
    Public Function traduzr(FRM As Report, plingua As Long)
        ' Tradução de Relatórios
        'Dim db As Database
        Dim POS As Long
        Dim nomesub As String
        Dim dicionario As ADODB.Recordset
        Dim txt As String
        Dim TEXTO As String
        Dim pge As Page
        Dim frm2 As Form
        Dim nomesubform As String, nomesubform1 As String, nomesubform2 As String
        Dim i As Long
        Dim ctl As control, Ctl1 As control, Ctl2 As control, Ctl3 As control, Ctl4 As control, Ctl5 As control
        Dim INTI As Integer, intCanEdit As Integer
        Select Case plingua
            Case 0
                txt = "NATIVO"
                GoTo FIM
            Case 1
                txt = "INGLES"
            Case 2
                txt = "FRANCES"
            Case 3
                txt = "ESPANHOL"
            Case 4
                txt = "ALEMAO"
        End Select
        'Set db = OpenDatabase(DIRECTORIO)
        'Set dicionario = db.OpenRecordset("dicionario")
        'dicionario.Index = "primarykey"
        dicionario = New ADODB.Recordset
        For Each ctl In FRM.Controls
            With ctl
                If ctl.Visible = True Then
                    Select Case .ControlType
                        Case acLabel
                            TEXTO = .Caption
                            'dicionario.Seek "=", texto

                            If dicionario.State = adStateOpen Then
                                dicionario.Close()
                            End If

                            dicionario.Open("select * from dicionario where nativo = '" & TEXTO & "'", cnn1, adOpenStatic, adLockOptimistic)
                            If Not dicionario.EOF Then
                                If Not IsNull(dicionario(txt)) Then
                                    .Caption = dicionario(txt)
                                End If
                            Else
                                dicionario.AddNew()
                                dicionario!NATIVO = TEXTO
                                dicionario.Update()
                            End If

                            '               Call write_dic2(ctl, texto, txt)
                        Case 112
                            'nomesub = .SourceObject
                            nomesub = .Name
                            POS = InStr(1, nomesub, ".")
                            nomesubform1 = Trim(Mid(nomesub, POS + 1, 50))
                            ' MsgBox (nomesubform1)
                            ' MsgBox (frm.Report(nomesubform1).Controls.Count)
                            For Each Ctl3 In FRM.Report(nomesubform1).Controls
                                With Ctl3
                                    Select Case Ctl3.ControlType
                                        Case acLabel
                                            TEXTO = .Caption
                                            '        MsgBox (.Caption)
                                            Call write_dic2(Ctl3, TEXTO, txt, plingua)
                                    End Select
                                End With
                            Next



                        Case Else
                            GoTo siga
                    End Select
                End If
            End With
siga:
        Next
FIM:
        If dicionario.State = adStateOpen Then
            dicionario.Close()
        End If
    End Function
    Public Function traduzc(plingua)
        ' tradução de menus' ver o comando find???
        Dim ctl As Object, obj1 As control, Ctl1 As Object, Ctl2 As Object, Ctl3 As Object
        Dim Ctl4 As Object, Ctl5 As Object, Ctl6 As Object, Ctl7 As Object, Ctl8 As Object
        Dim TEXTO As String, txt As String
        Select Case plingua
            Case 0
                txt = "NATIVO"
            Case 1
                txt = "INGLES"
            Case 2
                txt = "FRANCES"
            Case 3
                txt = "ESPANHOL"
            Case 4
                txt = "ALEMAO"
        End Select

        With Application.CommandBars
            For Each ctl In Application.CommandBars("wingiic").Controls
                'MsgBox (ctl.Caption & "  " & ctl.Type)
                'TEXTO = ctl.Caption
                TEXTO = Nz(ctl.Tag, "")
                Call write_dic2(ctl, TEXTO, txt, plingua, "S")
                Ctl1 = ctl.commandbar
                'MsgBox (ctl1.Type)

                For Each Ctl2 In Ctl1.Controls
                    'MsgBox (Ctl2.Caption & "  " & Ctl2.Type & " " & Ctl2.Tag)
                    'texto = Ctl2.Caption
                    TEXTO = Nz(Ctl2.Tag, "")
                    Call write_dic2(Ctl2, TEXTO, txt, plingua, "S")
                    'MsgBox (Ctl2.Type)
                    If Ctl2.Type = 10 Then
                        Ctl3 = Ctl2.commandbar
                        For Each Ctl4 In Ctl3.Controls
                            'MsgBox (Ctl4.Caption & "  " & Ctl4.Type)
                            'texto = Ctl4.Caption
                            '-----
                            TEXTO = Nz(Ctl4.Tag, "")

                            Call write_dic2(Ctl4, TEXTO, txt, plingua, "S")

                            If Ctl4.Type = 10 Then
                                Ctl5 = Ctl4.commandbar
                                For Each Ctl6 In Ctl5.Controls
                                    'MsgBox (Ctl6.Caption & "  " & Ctl6.Type)
                                    'texto = Ctl6.Caption
                                    TEXTO = Nz(Ctl6.Tag, "")
                                    Call write_dic2(Ctl6, TEXTO, txt, plingua, "S")

                                    If Ctl6.Type = 10 Then
                                        Ctl7 = Ctl6.commandbar
                                        For Each Ctl8 In Ctl7.Controls
                                            'MsgBox (Ctl8.Caption & "  " & Ctl8.Type)
                                            'texto = Ctl8.Caption
                                            TEXTO = Nz(Ctl8.Tag, "")
                                            Call write_dic2(Ctl8, TEXTO, txt, plingua, "S")
                                        Next Ctl8
                                    End If
                                    '    Call write_dic2(Ctl6, texto, txt, plingua)
                                Next Ctl6
                            End If
                            '    Call write_dic2(Ctl4, texto, txt, plingua)
                        Next Ctl4
                    End If
                    '    Call write_dic2(Ctl2, texto, txt, plingua)
                Next Ctl2
            Next ctl
        End With

FIM:
    End Function
    Public Function write_dic2(pctl As Object, ptexto, ptxt, plingua, Optional pmenu As String = "N")
        'Dim db As Database
        Dim dicionario As ADODB.Recordset
        'Set db = OpenDatabase(DIRECTORIO)
        'Set dicionario = db.OpenRecordset("dicionario")
        'dicionario.Index = "primarykey"
        dicionario = New ADODB.Recordset
        'dicionario.Seek "=", ptexto

        If dicionario.State = adStateOpen Then
            dicionario.Close()
        End If

        dicionario.Open("select * from dicionario where nativo = '" & ptexto & "'", cnn1, adOpenStatic, adLockOptimistic)
        If Not dicionario.EOF Then
            If Not IsNull(dicionario(ptxt)) Then
                pctl.Caption = dicionario(ptxt)
            End If
        Else
            If ptexto <> "" Then
                If plingua = 0 Then
                    dicionario.AddNew()
                    dicionario!NATIVO = ptexto
                    If pmenu = "S" Then
                        dicionario!menu = True
                    Else
                        dicionario!menu = False
                    End If
                    dicionario.Update()
                End If
            End If
        End If
        If dicionario.State = adStateOpen Then
            dicionario.Close()
        End If
    End Function

    Public Function write_dic(pctl As Object, ptexto, ptxt)
        'Dim DBA As Database
        Dim dicionario As ADODB.Recordset
        'Set DBA = OpenDatabase(diravent)
        dicionario = New ADODB.Recordset
        'Set dicionario = DBA.OpenRecordset("dicionario")
        'dicionario.Index = "primarykey"
        dicionario.Open("SELECT * FROM DICIONARIO WHERE NATIVO = '" & ptexto & "'", cnn1, adOpenStatic, adLockOptimistic, adCmdText)

        'dicionario.Seek "=", ptexto
        If Not dicionario.EOF Then
            'If Not IsNull(dicionario(ptxt)) Then
            'pctl.Caption = dicionario(ptxt)
            If dicionario!OK = True Then
                pctl.Visible = True
            Else
                pctl.Visible = False
            End If
            'End If
        Else
            'If ptexto <> "" Then
            'dicionario.AddNew
            'dicionario!NATIVO = ptexto
            'dicionario!MENU = True
            'dicionario.Update
            'End If
        End If
        dicionario.Close()
        dicionario = Nothing
    End Function

    Public Function VerAtributos(ptemplate)
        Dim RST As ADODB.Recordset
        RST = New ADODB.Recordset

        On Error GoTo siga
        RST.Open("SELECT * FROM V_ATRIBUTO_MOD WHERE TEMPLATE = '" & ptemplate & "'", cnn1, adOpenStatic, adLockReadOnly, adCmdText)
        If Not RST.EOF Then
            t_desc1 = Nz(RST!DESC1, "")
            t_desc2 = Nz(RST!DESC2, "")
            t_desc3 = Nz(RST!DESC3, "")
            t_desc4 = Nz(RST!DESC4, "")
            t_desc5 = Nz(RST!DESC5, "")

            t_desc_i1 = Nz(RST!DESC1_I, "")
            t_desc_i2 = Nz(RST!DESC2_I, "")
            t_desc_i3 = Nz(RST!DESC3_I, "")
            t_desc_i4 = Nz(RST!DESC4_I, "")
            t_desc_i5 = Nz(RST!DESC5_I, "")

            t_desc_F1 = Nz(RST!DESC1_F, "")
            t_desc_F2 = Nz(RST!DESC2_F, "")
            t_desc_F3 = Nz(RST!DESC3_F, "")
            t_desc_F4 = Nz(RST!DESC4_F, "")
            t_desc_F5 = Nz(RST!DESC5_F, "")
        End If
siga:
        If RST.State = adStateOpen Then
            RST.Close()
        End If

    End Function

    Public Function ArmTemVPN(ByVal PARM As String) As Boolean
        On Error GoTo erro

        Dim rsArm As New ADODB.Recordset

        rsArm.Open("SELECT ARM, VPN FROM STKTAR WHERE ARM = '" & PARM & "'", cnn1, _
            adOpenForwardOnly, adLockReadOnly, adCmdText)

        If Not rsArm.EOF Then
            ArmTemVPN = Nz(rsArm.Fields("VPN").Value, False)
        End If

        Exit Function

erro:
        If (Err.Number - vbObjectError) = 3604 Then ' Não existe o campo VPN
            ArmTemVPN = P_VPN
        Else
            MsgBox(Err.Number - vbObjectError & vbCrLf & Err.Description)
        End If
    End Function

    Public Function TituloAplicacao(ptitulo As String)
        Dim obj As Object
        Dim dbs As Object
        Const conPropNotFoundError = 3270

        On Error GoTo ErrorHandler
        ' Set dbs = CurrentDb
        ' Change title bar.
        CurrentProject.Properties!AppTitle = ptitulo
        Application.RefreshTitleBar()
        Exit Function

ErrorHandler:
        If Err.Number = conPropNotFoundError Then
            obj = CurrentProject.CreateProperty("AppTitle", "X", ptitulo)

            CurrentProject.AccessObjectProperties.Add obj
        Else
            MsgBox("Error: " & Err.Number & vbCrLf & Err.Description)
        End If
        Resume Next
    End Function


End Module
