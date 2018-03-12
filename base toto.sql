create database toto_fo
use toto_fo
create table Equipe(
id_equipe int identity primary key,
Nom_equipe  Varchar(255),
Pays varchar(255),
)
create  table jour_simpl(
id_comp  int  primary key identity,
des_comp varchar(255),
date_comp date,
)
create table joueur (
id_joueur int primary key identity,
nom_joueur  varchar(255),
id_equipe int foreign key(id_equipe) references Equipe(id_equipe)
)
create table particepation(
id_joueur int foreign key(id_joueur) references joueur(id_joueur) ,
id_comp int foreign key(id_comp) references jour_simpl(id_comp),
point int
)
SELECT     dbo.joueur.id_joueur, dbo.joueur.nom_joueur
FROM         dbo.Equipe INNER JOIN
                      dbo.joueur ON dbo.Equipe.id_equipe = dbo.joueur.id_equipe
                      where  dbo.Equipe.id_equipe=2