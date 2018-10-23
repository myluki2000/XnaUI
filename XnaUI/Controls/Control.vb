Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Control
    Public MustOverride Sub Draw(sb As SpriteBatch)
    Public MustOverride Sub Update(gameTime As GameTime)

End Class
