<HTML>
<HEAD>
<TITLE>Lecture de la table modele</TITLE>
<LINK rel="stylesheet" href="style.css" type="text/css" />
</HEAD>
<BODY>
<?php
// Connexion � la BD
$host="localhost";
$user="root";
$pwd="";
$base="sio";
$idconnexion=mysql_connect($host,$user,$pwd);
$idbase=mysql_select_db($base);
if(!$idconnexion | !$idbase)
		{
		echo "<script type=text/javascript>";
		echo "alert('Connexion impossible � la base $base')</script>";
		}
else
	{
	// Ex�cuter la requ�te
	$requete="SELECT * FROM modele ORDER BY modele";
	$result=mysql_query($requete,$idconnexion);
	if($result)
		{
		$nbcol=mysql_num_fields($result);	// Nombre de colonnes (cf. SELECT *)
		$nbmod=mysql_num_rows($result);		// Nombre de lignes
	
		// Titre
		echo "<h1> Tous les $nbmod mod�les de voitures</h1>";
	
		// Formatage d'un tableau, d'abord l'ent�te, pus le d�tail
		echo "<table border=\"1\">";
		echo "<th>Id du modele</th> <th>Libell�</th>  <th>Carburant</th>";
	
		// mysql_fetch_array() retourne une ligne de r�sultat SELECT sous la forme 
		// d'un TABLEAU associatif (MYSQL_ASSOC) ou d'un tableau index� (MYSQL_NUM)
		// Ici, la variable $ligne correspond � un tableau avec autant d'�l�ments que des colonnes (SELECT *) 
		while($ligne=mysql_fetch_array($result,MYSQL_NUM))
			{
			// Une ligne du tableau
			echo "<tr>";
			// Parcours de chaque �l�ment (=COLONNE) du tableau
			// et affichage de la valeur correspondante...
			foreach($ligne as $valeur)
				echo "<td> $valeur </td>";
			echo "</tr>";
			}
		echo "</table>";
		}
	}
	
// Dans tous les cas on se d�connecte
mysql_close($idconnexion);
?>
</BODY>
</HTML>
