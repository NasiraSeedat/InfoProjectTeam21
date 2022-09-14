Option Strict On
Option Explicit On
Option Infer Off

Public Class frmDiseases

<<<<<<< Updated upstream
=======
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
        Dim choice As Integer = CInt(InputBox("Which disease do you want to view ?" & Environment.NewLine & "1- HIV & AIDS" & Environment.NewLine & "2- Malaria"))
        Select Case choice
            Case 1
                Dim prevelance As Double = CDbl(InputBox("What is the disease prevelance for " & CStr(choice) & " ?"))
                objHIV.TransmitionRates(prevelance)
            Case 2
                Dim prev As Double = CDbl(InputBox("What is the prevelance for " & CStr(choice) & " ?"))
                Malaria.TransmitionRates(prev)
        End Select
    End Sub

    Private Sub btnSeeDoc_Click(sender As Object, e As EventArgs) Handles btnSeeDoc.Click
        Dim NumSymptoms As Integer

        Dim persons(ObjDisease.NumberInfected) As Person
        For Np As Integer = 1 To ObjDisease.NumberInfected
            persons(Np) = New Person
            Dim choice As Integer = CInt(InputBox("Which disease does person " & CStr(Np) & "have?" & Environment.NewLine & "1- HIV & AIDS" & Environment.NewLine & "2- Malaria"))
            Select Case choice
                Case 1
                    objHIV.YearsWith = CInt(InputBox("How many years has person " & CStr(Np) & " had it?"))
                    Dim seedoc As Boolean = objHIV.SeeDoctor
                Case 2
                    Malaria.ParasiteType = CInt(InputBox("What parasite type is it ?" & Environment.NewLine & "Choose from 1 - 4."))
                    NumSymptoms = CInt(InputBox("How many malaria symptoms does person " & CStr(Np) & "have ?"))
                    Dim seedoc As Boolean = Malaria.SeeDoctor(Malaria.ParasiteType, NumSymptoms, seedoc)
            End Select

        Next Np
    End Sub
>>>>>>> Stashed changes
End Class
