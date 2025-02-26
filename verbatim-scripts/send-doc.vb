Sub SendDoc()
    Dim originalDoc As Document
    Set originalDoc = ActiveDocument

    ' Disable screen updating for faster execution
    Application.ScreenUpdating = False
    Application.DisplayAlerts = False

    ' Extract the folder path from the original document's file path
    Dim originalFolderPath As String
    Dim originalFilePath As String
    originalFolderPath = Left(originalDoc.FullName, InStrRev(originalDoc.FullName, Application.PathSeparator))
    originalFilePath = originalDoc.FullName

    ' Check if doc has previously been saved
    If ActiveDocument.Path = "" Then
        ' If not previously saved
        MsgBox "The current document must be saved at least once."
        Exit Sub
    End If

    ' If previously saved, create a copy
    Dim sendDoc As Document
    Set sendDoc = Documents.Add(ActiveDocument.FullName)

    Selection.WholeStory
    Selection.Find.ClearFormatting
    Selection.Find.Style = ActiveDocument.Styles("Analytic")
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = ""
        .Replacement.Text = ""
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll

    Selection.WholeStory
    Selection.Find.ClearFormatting
    Selection.Find.Style = ActiveDocument.Styles("Undertag")
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = ""
        .Replacement.Text = ""
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll


    Dim savePath As String
    savePath = originalFolderPath & "[S] " & originalDoc.Name
    ActiveDocument.SaveAs2 Filename:=savePath, FileFormat:=wdFormatDocumentDefault
End Sub
