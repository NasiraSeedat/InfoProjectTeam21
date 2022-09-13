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
    Private objHIV() As HIVandAIDS
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
        ObjDisease = New Disease
        type = CInt(InputBox("Which disease would you like to add to?" & vbNewLine & "1- HIV/AIDS" & vbNewLine & "2- Malaria", "Type of disease"))

        Select Case type
            Case 1

                ObjDisease.NumberInfected = CInt(InputBox("How many people have HIV/AIDS?", "People with HIV and AIDS"))
                ReDim ObjDisease.Persons(ObjDisease.NumberInfected)
                objHIV(ObjDisease.NumberInfected) = New HIVandAIDS
                grdHIVnAIDS.Rows = ObjDisease.NumberInfected + 1
                grdHIVnAIDS.Cols = 6
                For Np As Integer = 1 To ObjDisease.NumberInfected
                    ObjDisease.Persons(Np).Name = InputBox("What is person " & CStr(Np) & "'s name?", "Name")
                    ObjDisease.Persons(Np).Age = CInt(InputBox("How old is " & CStr(ObjDisease.Persons(Np).Name) & "?", "Age"))
                    objHIV(Np).YearsWith = CInt(InputBox("How many years does " & CStr(ObjDisease.Persons(Np).Name) & " have HIV and AIDS?", "years with"))

                Next Np
            Case 2
                ObjDisease.NumberInfected = CInt(InputBox("How many people have Malaria?", "People with Malaria"))
                grdMalaria.Rows = ObjDisease.NumberInfected + 1
        End Select

    End Sub
End Class

