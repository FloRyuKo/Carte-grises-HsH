<HTML>
<HEAD>
<TITLE>Lecture de la table modele</TITLE>
<LINK rel="stylesheet" href="style.css" type="text/css" />
</HEAD>
<BODY>
<?php
// Connexion à la BD
$host="localhost";
$user="root";
$pwd="";
$base="sio";
$idconnexion=mysql_connect($host,$user,$pwd);
$idbase=mysql_select_db($base);
if(!$idconnexion | !$idbase)
		{
		echo "<script type=text/javascript>";
		echo "alert('Connexion impossible à la base $base')</script>";
		}
else
	{
	// Exécuter la requête
	$requete="SELECT * FROM modele ORDER BY modele";
	$result=mysql_query($requete,$idconnexion);
	if($result)
		{
		$nbcol=mysql_num_fields($result);	// Nombre de colonnes (cf. SELECT *)
		$nbmod=mysql_num_rows($result);		// Nombre de lignes
	
		// Titre
		echo "<h1> Tous les $nbmod modèles de voitures</h1>";
	
		// Formatage d'un tableau, d'abord l'entête, pus le détail
		echo "<table border=\"1\">";
		echo "<th>Id du modele</th> <th>Libellé</th>  <th>Carburant</th>";
	
		// mysql_fetch_array() retourne une ligne de résultat SELECT sous la forme 
		// d'un TABLEAU associatif (MYSQL_ASSOC) ou d'un tableau indexé (MYSQL_NUM)
		// Ici, la variable $ligne correspond à un tableau avec autant d'éléments que des colonnes (SELECT *) 
		while($ligne=mysql_fetch_array($result,MYSQL_NUM))
			{
			// Une ligne du tableau
			echo "<tr>";
			// Parcours de chaque élément (=COLONNE) du tableau
			// et affichage de la valeur correspondante...
			foreach($ligne as $valeur)
				echo "<td> $valeur </td>";
			echo "</tr>";
			}
		echo "</table>";
		}
	}
	
// Dans tous les cas on se déconnecte
mysql_close($idconnexion);
?>
</BODY>
</HTML>
