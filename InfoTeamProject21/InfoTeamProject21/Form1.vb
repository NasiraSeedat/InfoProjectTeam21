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
    Private ObjDisease As Disease
    Private Malaria As Malaria
    Private objHIV As HIVandAIDS
    Private type As Integer

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

        Select Case type
            Case 1

                Dim NumberInfected As Integer = CInt(InputBox("How many people have HIV/AIDS?", "People with HIV and AIDS"))
                ObjDisease = New Disease
                ReDim ObjDisease.Persons(ObjDisease.NumberInfected)
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


                    'placing text in hiv& aids grid
                    PlaceHIVNAIDS(Np, 0, persons(Np).Name)
                    PlaceHIVNAIDS(Np, 1, CStr(persons(Np).Age))
                    PlaceHIVNAIDS(Np, 2, CStr(objHIV.YearsWith))
                Next Np
            Case 2
                ObjDisease.NumberInfected = CInt(InputBox("How many people have Malaria?", "People with Malaria"))
                grdMalaria.Rows = ObjDisease.NumberInfected + 1
        End Select

    End Sub

    Private Sub frmDiseases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlaceHIVNAIDS(0, 0, "Name")
        PlaceHIVNAIDS(0, 1, "Age")
        PlaceHIVNAIDS(0, 2, "Years with")


    End Sub

    Private Sub btnTransSurvRate_Click(sender As Object, e As EventArgs) Handles btnTransSurvRate.Click

    End Sub

    Private Sub btnSeeDoc_Click(sender As Object, e As EventArgs) Handles btnSeeDoc.Click

    End Sub
End Class

