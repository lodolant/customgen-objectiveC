' Generated from GenMyModel
Public Class Mario

Private coordonneesActuelles As Point
Private taille As Taille

	Sub New()
		' TODO : Complete constructor
	End Sub

	Public Sub avance()
		'Start of user code avance
		' TODO : Complete method
		
		'End of user code
	End Sub
	
	
	Public Sub recule()
		'Start of user code recule
		' TODO : Complete method
		
		'End of user code
	End Sub
	
	
	Public Sub monte()
		'Start of user code monte
		' TODO : Complete method
		
		'End of user code
	End Sub
	
	
	Public Sub descend()
		'Start of user code descend
		' TODO : Complete method
		
		'End of user code
	End Sub
	
	
	Private Function pasX()
		'Start of user code pasX
		' TODO : Complete method
		
		'End of user code
	End Function
	
	
	Private Function pasY()
		'Start of user code pasY
		' TODO : Complete method
		
		'End of user code
	End Function
	
	
	Public Sub eatSomeMushroom(ByVal newSize As Taille, ByVal newPosition As Point)
		'Start of user code eatSomeMushroom
		' TODO : Complete method
		
			If (taille < 1) ' move back
				
			End If
			If (taille > 1) ' move back
				
			End If
			If (coordonneesActuelles < 5) ' eat mushroom
				
			End If
				If (taille < 1) ' move back
					
				End If
				If (taille > 1) ' move back
					
				End If
			If (coordonneesActuelles > 5) ' eat mushroom
				
					If (taille < 1) ' move back
						
					End If
					If (taille > 1) ' move back
						
					End If
			End If
		
		'End of user code
	End Sub
	
	
	Public Property coordonneesActuelles()
	 As Point
		Get
			Return coordonneesActuelles
		End Get
		Set(ByVal value As Point)
			coordonneesActuelles = value
		End Set
	End Property
	
	
	
End Class
