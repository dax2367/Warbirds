Public Class Warbirds
    '===============================================================================================================
    ' Author:      Holly Eaton
    ' 
    ' Program:     Warbirds     
    ' 
    ' Dev Env:     Visual Studio
    ' 
    ' Description:
    '  Purpose:    Project that is an image viewer – shows picture of each plane and presents information about it.
    '  
    '  Input:      The user clicks the button with the name of the plane that they want to view and read more about. 
    '
    '  Process:    The imagebox property is changed to the image of the selected plane; the visibility property of
    '              matching label is switched from false to true so the information text for that plane is visible.
    '
    '  Output:     When the user clicks the exit button a message box displays credits for the photos and information.
    ' 
    '================================================================================================================== 



    Private Sub btnHellcat_Click(sender As Object, e As EventArgs) Handles btnHellcat.Click
        'Change the text property of gbxText from Welcome to F6F Hellcat.
        gbxText.Text = "F6F Hellcat"

        'Change the image property of picPlane to image of F6FHellcat.
        picPlane.Image = EatonCh2Proj.My.Resources.Resources.F6FHellcat

        'Change the visible property of lblWelcomeText, lblLightningText, lblWarhawkText,
        'lblThunderboltText, lblMustangText, lblCorsairText to invisible
        lblWelcomeText.Visible = False
        lblLightningText.Visible = False
        lblWarhawkText.Visible = False
        lblThunderboltText.Visible = False
        lblMustangText.Visible = False
        lblCorsairText.Visible = False

        'Change the visible property of lblHellcatText to visible.
        lblHellcatText.Visible = True


    End Sub

    Private Sub btnLightning_Click(sender As Object, e As EventArgs) Handles btnLightning.Click
        'Change the text property of gbxText  to P38 Lightning.
        gbxText.Text = "P38 Lightning"

        'Change the image property of picPlane to image of P38 Lightning.
        picPlane.Image = EatonCh2Proj.My.Resources.Resources.P38Lightning1a

        'Change the visible property of lblWelcomeText, lblHellcatText, lblWarhawkText,
        'lblThunderboltText, lblMustangText, lblCorsairText to invisible
        lblWelcomeText.Visible = False
        lblHellcatText.Visible = False
        lblWarhawkText.Visible = False
        lblThunderboltText.Visible = False
        lblMustangText.Visible = False
        lblCorsairText.Visible = False

        'Change the visible property of lblLightningText to visible.
        lblLightningText.Visible = True


    End Sub

    Private Sub btnWarhawk_Click(sender As Object, e As EventArgs) Handles btnWarhawk.Click
        'Change the text property of gbxText from Welcome to P40 Warhawk.
        gbxText.Text = "P40 Warhawk"

        'Change the image property of picPlane to image of P40 Warhawk.
        picPlane.Image = EatonCh2Proj.My.Resources.Resources.p40AmVolGrpjpg

        'Change the visible property of lblWelcomeText, lblHellcatText, lblLightningText,
        'lblThunderboltText, lblMustangText, lblCorsairText to invisible
        lblWelcomeText.Visible = False
        lblHellcatText.Visible = False
        lblLightningText.Visible = False
        lblThunderboltText.Visible = False
        lblMustangText.Visible = False
        lblCorsairText.Visible = False


        'Change the visible property of lblWarhawkText to visible.
        lblWarhawkText.Visible = True


    End Sub

    Private Sub btnThunderbolt_Click(sender As Object, e As EventArgs) Handles btnThunderbolt.Click
        'Change the text property of gbxText from Welcome to P47 Thunderbolt.
        gbxText.Text = "P47 Thunderbolt"

        'Change the image property of picPlane to image of P47 Thunderbolt.
        picPlane.Image = EatonCh2Proj.My.Resources.Resources.P47Thunderbolt

        'Change the visible property of lblWelcomeText, lblHellcatText, lblLightningText,
        'lblWarhawkText, lblMustangText, lblCorsairText to invisible
        lblWelcomeText.Visible = False
        lblHellcatText.Visible = False
        lblLightningText.Visible = False
        lblWarhawkText.Visible = False
        lblMustangText.Visible = False
        lblCorsairText.Visible = False


        'Change the visible property of lblThunderboltText to visible.
        lblThunderboltText.Visible = True

    End Sub

    Private Sub btnMustang_Click(sender As Object, e As EventArgs) Handles btnMustang.Click
        'Change the text property of gbxText from Welcome to P51 Mustang.
        gbxText.Text = "P51 Mustang"

        'Change the image property of picPlane to image of P51 Mustang.
        picPlane.Image = EatonCh2Proj.My.Resources.Resources.P51_Mustang_Red_Tail

        'Change the visible property of lblWelcomeText, lblHellcatText, lblLightningText,
        'lblWarhawkText, lblThunderboltText, lblCorsairText to invisible
        lblWelcomeText.Visible = False
        lblHellcatText.Visible = False
        lblLightningText.Visible = False
        lblWarhawkText.Visible = False
        lblThunderboltText.Visible = False
        lblCorsairText.Visible = False


        'Change the visible property of lblMustangText to visible.
        lblMustangText.Visible = True

    End Sub

    Private Sub btnCorsair_Click(sender As Object, e As EventArgs) Handles btnCorsair.Click
        'Change the text property of gbxText from Welcome to F4UCorsair.
        gbxText.Text = "F4U Corsair"

        'Change the image property of picPlane to image of F4U Corsai.
        picPlane.Image = EatonCh2Proj.My.Resources.Resources.FG_1DCorsair

        'Change the visible property of lblWelcomeText, lblHellcatText, lblLightningText,
        'lblWarhawkText, lblThunderboltText, lblMustangText to invisible
        lblWelcomeText.Visible = False
        lblHellcatText.Visible = False
        lblLightningText.Visible = False
        lblWarhawkText.Visible = False
        lblThunderboltText.Visible = False
        lblMustangText.Visible = False


        'Change the visible property of lblCorsairText to visible.
        lblCorsairText.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Displays Exit message box
        MessageBox.Show("Credits:" + vbCrLf + "Dawn's Grumman Hellcat Shrine" + vbCrLf + "War Bird Alley" + vbCrLf +
                        "charleslindbergh.com" + vbCrLf +
                        "Ryan, Cornelius. A Bridge Too Far. New York: Simon & Schuster, 1974" + vbCrLf +
                        "National Museum of the USAF - Fact Sheet : ESCORT EXCELLENCE, Charles Lindbergh and the 475th Fighter Group" + vbCrLf +
                        "American Airpower Museum" + vbCrLf +
                        " " + vbCrLf + "Goodbye!")

        'Exits the application
        Me.Close()
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Change the text property of gbxText back to Welcome.
        gbxText.Text = "Welcome to the WWII Warbirds Guide"

        'Change the image property of picPlane to image of p40Formation.
        picPlane.Image = EatonCh2Proj.My.Resources.Resources.p40Formation

        'Change the visible property of lblHellcatText, lblLightningText,
        'lblWarhawkText, lblThunderboltText, lblMustangText, lblCorsair Textto invisible
        lblHellcatText.Visible = False
        lblLightningText.Visible = False
        lblWarhawkText.Visible = False
        lblThunderboltText.Visible = False
        lblMustangText.Visible = False
        lblCorsairText.Visible = False


        'Change the visible property of lblWelcomeText to visible.
        lblWelcomeText.Visible = True
    End Sub
End Class
