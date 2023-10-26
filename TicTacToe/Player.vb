Public Class Player

    Private _name As String
    Private _score As Integer = 0
    Private _piece As Image

    ''' <summary>
    ''' Creates a new Player
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Creates a new Player with the provided name.
    ''' </summary>
    ''' <param name="name">String: Used as identifier for player</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal name As String)
        Me._name = name
    End Sub

    ''' <summary>
    ''' Name of Player, identifier
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Name As String
        Get
            Return Me._name
        End Get
        Set(value As String)
            Me._name = value
        End Set
    End Property

    ''' <summary>
    ''' Players Score
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Score As Integer
        Get
            Return Me._score
        End Get
        Set(value As Integer)
            Me._score = value
        End Set
    End Property

    ''' <summary>
    ''' Image Player is using in game.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Piece As Image
        Get
            Return Me._piece
        End Get
        Set(value As Image)
            Me._piece = value
        End Set
    End Property
End Class
