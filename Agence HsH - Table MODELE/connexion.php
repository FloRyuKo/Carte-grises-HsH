<?php
ini_set("display_errors","off");
ini_set("track_errors","on");
//----------------------------------------------------------------------
// Connexion � une BD situ�e sur un ordinateur h�te sous un utilisateur
// En cas d'erreur, une bo�te de dialogue Javascript est affich�e sinon, 
// l'identifiant de connexion est retourn�
//----------------------------------------------------------------------
function connexion($base,$host,$user,$pwd)
{
	$idconnexion=mysql_connect($host,$user,$pwd);
	$idbase=mysql_select_db($base);
	if(!$idconnexion | !$idbase)
		{
		echo "<script type=text/javascript>";
		echo "alert('Connexion impossible � la base $base')</script>";
		}
	return $idconnexion;
}

//---------------------------------------------------
// Deconnexion � partir d'un identifiant de connexion
//---------------------------------------------------
function deconnexion($id_connexion)
{
mysql_close($id_connexion);
}
?>




