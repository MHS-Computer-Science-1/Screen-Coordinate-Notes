Public Class Form1
    Dim frame As Bitmap
    Dim framePen, formPen As Graphics


    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        'DRAW STUFF HERE
        '---------------

        'Screen Coordinates
        ' - (0, 0) is the origin
        ' - getWidth() and getHeight() give us the width and height of the form

        '           (x, y)
        '   Origin: (0, 0) ----------------- 
        '                  |               |
        '                  |     form      |
        '                  |               |
        ' (0, getHeight()) -----------------


        'DrawImage places an image resource on the screen at an (x, y) point

        'Draw your background first!


        'Draw moon top-left


        'Draw moon top-right using a Point
        Dim topRight As Point


        'Draw moon bottom-left 
        Dim bottomLeft As Point


        'Draw moon bottom-right
        Dim bottomRight As Point


        'Draw moon top-middle
        Dim topMiddle As Point


        'Draw moon bottom-middle
        Dim bottomMiddle As Point


        'Draw moon left-middle
        Dim leftMiddle As Point


        'Draw moon right-middle
        Dim rightMiddle As Point


        'Draw moon centered
        Dim center As Point



        'Do not alter below this line
        formPen.DrawImage(frame, 0, 0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Do not alter this code
        frame = New Bitmap(getWidth(), getHeight())
        formPen = Me.CreateGraphics
        framePen = Graphics.FromImage(frame)

        formPen.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        formPen.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        formPen.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        formPen.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

        framePen.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        framePen.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        framePen.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        framePen.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

        GameTimer.Start()
    End Sub

    Function getWidth() As Integer
        'Returns the usable width of the form
        Return Me.ClientSize.Width
    End Function
    Function getHeight() As Integer
        'Returns the usable height of the form
        Return Me.ClientSize.Height
    End Function
End Class
