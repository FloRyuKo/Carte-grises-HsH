<?php
ini_set("display_errors","off");
ini_set("track_errors","on");
//----------------------------------------------------------------------
// Connexion à une BD située sur un ordinateur hôte sous un utilisateur
// En cas d'erreur, une boîte de dialogue Javascript est affichée sinon, 
// l'identifiant de connexion est retourné
//----------------------------------------------------------------------
function connexion($base,$host,$user,$pwd)
{
	$idconnexion=mysql_connect($host,$user,$pwd);
	$idbase=mysql_select_db($base);
	if(!$idconnexion | !$idbase)
		{
		echo "<script type=text/javascript>";
		echo "alert('Connexion impossible à la base $base')</script>";
		}
	return $idconnexion;
}

//---------------------------------------------------
// Deconnexion à partir d'un identifiant de connexion
//---------------------------------------------------
function deconnexion($id_connexion)
{
mysql_close($id_connexion);
}
?>




