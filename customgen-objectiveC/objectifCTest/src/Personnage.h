#import <Foundation/Foundation.h>

// Generated from GenMyModel
@interface Personnage : NSObject
{
	Arme * Arme;
	NSString * String;
	int Integer;
}

/* Methods of the class*/
- (id) initAvecNom(NSString *)unNom;
- (void) jouerContre(Personnage *)adversaire(Arme *)arme;
- (void) recevoirDegats(int)degats;
- (void) attaquer(Personnage *)cible;
- (void) ameliorerEpee;

/* Accessors of the variables */
- (Arme *) epee;
- (void) setEpee:(Arme *) newEpee;

- (NSString *) nom;
- (void) setNom:(NSString *) newNom;

- (int) vie;
- (void) setVie:(int) newVie;


/* Classical Objective-C methods */
- (NSString *) description;
- (void) dealloc;

@end
