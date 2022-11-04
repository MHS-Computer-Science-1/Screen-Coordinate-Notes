Public Class Form1
    Dim frame As Bitmap
    Dim g, gFinal As Graphics


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
        gFinal.DrawImage(frame, 0, 0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Do not alter this code
        frame = New Bitmap(getWidth(), getHeight())
        gFinal = Me.CreateGraphics
        g = Graphics.FromImage(frame)

        gFinal.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        gFinal.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        gFinal.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        gFinal.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

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
