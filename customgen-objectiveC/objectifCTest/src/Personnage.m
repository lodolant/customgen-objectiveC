#import <Personnage.h>

// Generated from GenMyModel
@implementation Personnage

/* Methods of the class */
- (id) initAvecNom(NSString *)unNom
{
	if((self = [super init]))
	{
		// TODO auto-generated constructor
	}
	return self;
}
- (void) jouerContre(Personnage *)adversaire(Arme *)arme
{
	// TODO auto-generated method
}
- (void) recevoirDegats(int)degats
{
	// TODO auto-generated method
}
- (void) attaquer(Personnage *)cible
{
	// TODO auto-generated method
}
- (void) ameliorerEpee
{
	// TODO auto-generated method
}


/* Accessors of the class */
- (Arme *) epee
{
	return epee;
}

- (void) setEpee:(Arme *) newEpee
{
	epee = newEpee;
}
- (NSString *) nom
{
	return nom;
}

- (void) setNom:(NSString *) newNom
{
	nom = newNom;
}
- (int) vie
{
	return vie;
}

- (void) setVie:(int) newVie
{
	vie = newVie;
}


/* Classical Objective-C methods */
- (NSString *) description
{
	// TODO auto-generated method
	return [super description];
}

- (void) dealloc
{
	// TODO auto-generated method
	[super dealloc];
}
