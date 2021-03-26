
<h2>Projet:</h2>
 Application type « Windows Forms » pour la gestion de stock d’une supérette. 

<h2>Demo:</h2>https://www.youtube.com/watch?v=nPWcR7qYYsY

<h2>les outils utilisés:</h2>
<pre>
   Visual studio.
   C#
   Entity Framework LinQ
   Sql server
</pre>


<h2>Cahier de charge:</h2>
<pre>
- Spécificités : 
• Modélisation de l’application.
• Créer la base de données sous SQL SERVER
• Réaliser une interface utilisateur conviviale et ergonomique pour l'application 
• Un tableau de bord qui contient des statistiques (par jour/ semaine/ mois/ ans...) et qui 
• affiche le nombre des ventes / achat / et gain par jour.

<b>Gestion des produits : </b>
•  Liste de tous les produits disponible en stock et non disponible.
•  Ajout d’un champ recherche rapide de produit par nom pour vérifier sa 
disponibilité. 
• Liste des produits disponibles en stock seulement avec précision du nombre 
restant.
• Interface d’ajout de produit (Nom, Image, Prix, …)
•  Quand on clique sur l’un des produits de la liste produits, une nouvelle fenêtre 
doit s’ouvrir pour donner les détails du produit choisi.
• Dès l'ajout d'un nouveau produit, ajouter la date d'expiration
• Dès que le produit atteigne la date d’expiration, il doit automatiquement être 
déstocké, et son statut doit changer de disponible à non disponible.
• Liste des produits qui doivent être déstockés. 
• Interface résumant le nombre de ventes par jour, le gain en dhs, le nombre de 
produits en déstockage et la perte en dhs. 

<b>Gestion des fournisseurs</b>
o Liste des fournisseurs (Nom, Adresse, Contact)
o Fenêtre détaillant chaque fournisseur quand on clique sur l’un d’eux dans la liste 
fournisseur. 
• Fenêtre pour passer une commande chez un fournisseur, où on précise le produit, 
la quantité, le prix grossiste, la date de demande, la date d’arrivé souhaitée… 
• Un fois les produits arrivés la commande doit disparaitre et la liste produits doit 
être mise à jour. 
• Fenêtre résumant le nombre de produits en commande, le prix des commandes, et 
le prix total.
• L’ajout d’un bouton impression du log journalier dans la page d’accueil qui résumera 
le tout sous forme d’un rapport fichier texte.
 
<b>Gestion d’exception : </b>
• Au cas où on ajoute un nouveau produit et le fournisseur n’est pas listé dans la 
base de donnés. 
• Au cas où un produit commandé chez le fournisseur n’est plus fabriqué. 
• D’autres exceptions …
• Utilisation des collections, de LinQ, Entity Framework et WCF.
</pre>
