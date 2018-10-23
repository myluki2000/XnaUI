Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class UIScreen
    Public Controls As New List(Of Control)

    Public Sub Draw(sb As SpriteBatch)
        For Each c In Controls
            c.Draw(sb)
        Next
    End Sub

    Public Sub Update(gameTime As GameTime)
        For Each c In Controls
            c.Update(gameTime)
        Next
    End Sub
End Class
