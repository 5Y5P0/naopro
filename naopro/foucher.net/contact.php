<?php

/* Récupération des valeurs des champs du formulaire */
if (get_magic_quotes_gpc())
{
    $name = stripslashes($_POST['name']); 
    $message = stripslashes($_POST['message']); 
	$email = stripslashes($_POST['email']); 
} 
else
{  
    $name = $_POST['name']; 
    $message = $_POST['message']; 
	$email = $_POST['email']; 

}

$name = htmlspecialchars($name);
$message = htmlspecialchars($message);
$email = htmlspecialchars($email);

/* Préparation mail */

$headers ='From: postmaster@foucher.net'."\n";
$headers .='Reply-To: '.$name.'<'.$email.'>'."\n";
$headers .='Content-Type: text/plain; charset="iso-8859-1"'."\n";
$headers .='Content-Transfer-Encoding: 8bit';

$message = $message."\n\n".$name." : ".$email;

/* envoi mail */

mail('sebastien@foucher.net', 'Contact de visiteur', $message, $headers); 

header('Location: /index.html#contact');  

?>