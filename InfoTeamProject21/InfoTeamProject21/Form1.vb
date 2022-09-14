' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Moyo, CT (221039267)
' Team Member 2 Details: Seedat, N (222003082)
' Team Member 3 Details: Mabaire, N ()
' Team Member 4 Details: e.g. Ruzuidenhout, R ()
' Practical: Team Project
' Class name: (frmDiseases)
' *****************************************************************

'My option statements...
Option Strict On
Option Explicit On
Option Infer Off


Public Class frmDiseases
    Private ObjDisease() As Disease
    Private Malaria As Malaria
    Private objHIV As HIVandAIDS
    Private type As Integer
    Private nD As Integer

    'Sub for placing text in the grid for HIV & AIDS
    Public Sub PlaceHIVNAIDS(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdHIVnAIDS.Row = r
        grdHIVnAIDS.Col = c
        grdHIVnAIDS.Text = t
    End Sub
    'sub for displaying text in the grid for Malaria
    Public Sub PlaceMalaria(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdMalaria.Row = r
        grdMalaria.Col = c
        grdMalaria.Text = t
    End Sub



    Private Sub btnInputInfo_Click(sender As Object, e As EventArgs) Handles btnInputInfo.Click
        type = CInt(InputBox("Which disease would you like to add to?" & vbNewLine & "1- HIV/AIDS" & vbNewLine & "2- Malaria", "Type of disease"))
        nD = 2
        ReDim ObjDisease(nD)
        For i As Integer = 1 To nD
            ObjDisease(i) = New Disease
        Next i


        Select Case type
            Case 1


                Dim NumberInfected As Integer = CInt(InputBox("How many people have HIV/AIDS?", "People with HIV and AIDS"))
                grdHIVnAIDS.Rows = NumberInfected + 1
                grdHIVnAIDS.Cols = 6
                Dim persons(NumberInfected) As Person
                For Np As Integer = 1 To NumberInfected
                    objHIV = New HIVandAIDS
                    persons(Np) = New Person
                    persons(Np).Name = InputBox("What is person " & CStr(Np) & "'s name?", "Name")
                    persons(Np).Age = CInt(InputBox("How old is " & CStr(persons(Np).Name) & "?", "Age"))
                    objHIV.Persons = persons
                    objHIV.YearsWith = CInt(InputBox("How many years does " & CStr(objHIV.Persons(Np).Name) & " have HIV and AIDS?", "years with"))
                    'Upcasting HIV....
                    ObjDisease(1) = objHIV

                    'placing text in hiv& aids grid
                    PlaceHIVNAIDS(Np, 0, persons(Np).Name)
                    PlaceHIVNAIDS(Np, 1, CStr(persons(Np).Age))
                    PlaceHIVNAIDS(Np, 2, CStr(objHIV.YearsWith))
                Next Np
            Case 2
                Malaria.NumberInfected = CInt(InputBox("How many people have Malaria?", "People with Malaria"))
                grdMalaria.Rows = Malaria.NumberInfected + 1
                'Upcasting Malaria...
                ObjDisease(2) = Malaria
        End Select

    End Sub

    Private Sub frmDiseases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlaceHIVNAIDS(0, 0, "Name")
        PlaceHIVNAIDS(0, 1, "Age")
        PlaceHIVNAIDS(0, 2, "Years with")


    End Sub

    Private Sub btnTransSurvRate_Click(sender As Object, e As EventArgs) Handles btnTransSurvRate.Click

        Dim persons(objHIV.NumberInfected) As Person
        For np As Integer = 1 To objHIV.NumberInfected
            persons(np) = New Person
            Dim Haart As Boolean = CBool(InputBox("Did person " & CStr(np) & " undergo HAART?"))
            Dim TimeInfect As Integer = CInt(InputBox("How long has person " & CStr(np) & " been infected?"))
            Dim survrate As Double = objHIV.SurvivalRate(Haart, TimeInfect)
            'Please add display code...
        Next np
        For i As Integer = 1 To nD
            ObjDisease(i).Prevelance = CDbl(InputBox("What is the disease prevelance for disease " & CStr(i) & " ?"))
            Dim transrate As Double = ObjDisease(i).TransmitionRates(ObjDisease(i).Prevelance)
            'Please add display code.....
        Next i

    End Sub

    Private Sub btnSeeDoc_Click(sender As Object, e As EventArgs) Handles btnSeeDoc.Click
        Dim NumSymptoms As Integer
        Dim Infected As Integer = CInt(InputBox("How many people are infected?"))
        Dim persons(Infected) As Person

        For Np As Integer = 1 To Infected
            persons(Np) = New Person
            Dim choice As Integer = CInt(InputBox("Which disease does person " & CStr(Np) & " have?" & vbNewLine & "1- Malaria" & vbNewLine & "2- HIV & AIDS", "Type of disease"))

            Select Case choice
                Case 1
                    Malaria.ParasiteType = CInt(InputBox("What parasite type is it ?" & Environment.NewLine & "Choose from 1 - 4."))
                    NumSymptoms = CInt(InputBox("How many malaria symptoms does person " & CStr(Np) & "have ?"))
                    Dim seedoc As Boolean = Malaria.SeeDoctor(Malaria.ParasiteType, NumSymptoms, seedoc)
                Case 2
                    Dim seedoctor As Boolean = objHIV.SeeDoctor()
            End Select
            'Please add display code......
        Next Np
    End Sub
End Class

