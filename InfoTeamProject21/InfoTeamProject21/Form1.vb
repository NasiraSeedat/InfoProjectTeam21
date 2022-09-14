' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Moyo, CT (221039267)
' Team Member 2 Details: Seedat, N (222003082)
' Team Member 3 Details: Mabaire, N (222068097)
' Team Member 4 Details: Bezuidenhout, R (222153482)
' Practical: Team Project
' Class name: (frmDiseases)
' *****************************************************************

'My option statements...
Option Strict On
Option Explicit On
Option Infer Off


Public Class frmDiseases
    Private ObjDisease() As Disease
    Private type, NumberInfectedHiv, NumberInfectedMalaria As Integer

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

                NumberInfectedHiv = CInt(InputBox("How many people have HIV/AIDS?", "People with HIV and AIDS"))
                grdHIVnAIDS.Rows = NumberInfectedHiv + 1


                Dim persons(NumberInfectedHiv) As HIVandAIDS

                For Np As Integer = 1 To NumberInfectedHiv
                    persons(Np) = New HIVandAIDS
                    persons(Np).Name = InputBox("What is person " & CStr(Np) & "'s name?", "Name")
                    persons(Np).Age = CInt(InputBox("How old is " & CStr(persons(Np).Name) & "?", "Age"))

                    persons(Np).YearsWith = CInt(InputBox("How many years does " & CStr(persons(Np).Name) & " have HIV and AIDS?", "years with"))
                    Dim HAART As Boolean
                    HAART = CBool(InputBox("Is " & CStr(persons(Np).Name) & " on HAART(HIV/AIDS treatment)" & vbNewLine & "True or false", "HAART"))

                    'placing text in hiv& aids grid
                    PlaceHIVNAIDS(Np, 0, persons(Np).Name)
                    PlaceHIVNAIDS(Np, 1, CStr(persons(Np).Age))
                    PlaceHIVNAIDS(Np, 2, CStr(persons(Np).YearsWith))
                    PlaceHIVNAIDS(Np, 3, CStr(persons(Np).CalcTypefARV(persons(Np).YearsWith)))
                    PlaceHIVNAIDS(Np, 4, CStr(persons(Np).SurvivalRate(HAART, CInt(persons(Np).YearsWith))))
                Next Np
                ObjDisease(1).Persons = persons
                ObjDisease(1).NumberInfected = NumberInfectedHiv


            Case 2
                NumberInfectedMalaria = CInt(InputBox("How many people have Malaria?", "People with Malaria"))
                grdMalaria.Rows = NumberInfectedMalaria + 1

                Dim persons(NumberInfectedMalaria) As Malaria
                For N As Integer = 1 To NumberInfectedMalaria
                    persons(N) = New Malaria

                    persons(N).Name = InputBox("What is person " & CStr(N) & "'s name?", "Name")
                    persons(N).Age = CInt(InputBox("How old is " & CStr(persons(N).Name) & "?", "Age"))

                    persons(N).ParasiteType = CInt(InputBox("What parasite did " & CStr(persons(N).Name) & " get Malaria from?" & vbNewLine & "1- plasmodium falciparum" & vbNewLine & "2- plasmodium vivax" & vbNewLine & "3- plasmodium ovale" & vbNewLine & "4- plasmodium malariae", "Parasite type"))
                    persons(N).NumSymptoms = CInt(InputBox("How many of these symptoms does " & CStr(persons(N).Name) & " have?" & vbNewLine & "1. Chills, 2. Fatigue, 3. Fever, 4. Night sweats, 5. Shivering, 6. Sweating, 7. Diarrhoea, 8. Nausea, 9. Vomiting, 10. Headache", "Number of symptoms"))


                    'Placing text in the malaria grid
                    PlaceMalaria(N, 0, persons(N).Name)
                    PlaceMalaria(N, 1, CStr(persons(N).Age))
                    PlaceMalaria(N, 2, CStr(persons(N).ParasiteType))
                    PlaceMalaria(N, 3, CStr(persons(N).NumSymptoms))

                Next N

                ObjDisease(2).Persons = persons
                ObjDisease(2).NumberInfected = NumberInfectedMalaria

        End Select

    End Sub

    Private Sub frmDiseases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdHIVnAIDS.Cols = 6
        PlaceHIVNAIDS(0, 0, "Name")
        PlaceHIVNAIDS(0, 1, "Age")
        PlaceHIVNAIDS(0, 2, "Years with")
        PlaceHIVNAIDS(0, 3, "Type of ARV on")
        PlaceHIVNAIDS(0, 4, "Survival Rate")
        PlaceHIVNAIDS(0, 5, "See a doctor")


        grdMalaria.Cols = 6
        PlaceMalaria(0, 0, "Name")
        PlaceMalaria(0, 1, "Age")
        PlaceMalaria(0, 2, "Parasite Type")
        PlaceMalaria(0, 3, "Number of symptoms")
        PlaceMalaria(0, 4, "see a doctor")

        ReDim ObjDisease(2)
        ObjDisease(1) = New Disease
        ObjDisease(2) = New Disease


    End Sub

    Private Sub btnTransSurvRate_Click(sender As Object, e As EventArgs) Handles btnTransSurvRate.Click
        Dim HivPrev As Double
        Dim MalariaPrev As Double
        HivPrev = CDbl(InputBox("What is the disease prevalence for HIV and AIDS?", "Prevalence"))

        txtTransHIVnAIDS.Text = CStr(ObjDisease(1).TransmitionRates(HivPrev))

        MalariaPrev = CDbl(InputBox("What is the disease prevalence for Malaria?", "Prevalence"))
        txtTransMalaria.Text = CStr(ObjDisease(2).TransmitionRates(MalariaPrev))


    End Sub

    Private Sub btnSeeDoc_Click(sender As Object, e As EventArgs) Handles btnSeeDoc.Click


        'polymorphic function
        For i As Integer = 1 To NumberInfectedHiv
            PlaceHIVNAIDS(i, 5, CStr(ObjDisease(1).Persons(i).SeeDoctor()))
        Next i

        For j As Integer = 1 To NumberInfectedMalaria
            PlaceMalaria(j, 4, CStr(ObjDisease(2).Persons(j).SeeDoctor()))
        Next j

    End Sub
End Class

