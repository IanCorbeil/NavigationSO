using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe ScriptableObject pour gerer les infos du Joueur (nom, vies, score).
/// Contient une mecanique de reinitialisation.
/// </summary>
[CreateAssetMenu(menuName = "Infos du joueur", fileName = "InfosDuJoueur")] //consigne de creation du menu de creation de l'asset
public class InfosJoueur : ScriptableObject //preciser que c'est un S.O.
{
    //DEBUT DES CHAMPS SERIALISES
    [Header("Valeurs initiales")] //Entete de section pour les Valeurs initiales (debut de partie)
    [SerializeField] private string _nomIni; //nom par defaut
    [SerializeField] private int _vieIni = 3; //int, nb initial de vies (3 par defaut)
    [SerializeField] private int _scoreIni = 0; //int, score initial (0 par defaut)

    [Header("Valeurs en cours")] //Entete de section pour les Valeurs en cours (pendant la partie)
    [SerializeField] private string _nom; //nom durant la partie
    [SerializeField] private int _vie; //int, nb de vies du joueur durant la partie
    [SerializeField] private int _score; //int, score du joueur durant la partie
    //FIN DES CHAMPS SERIALISES

    [HideInInspector] private string _nomIntermediaire; //(cache ds l'inspecteur) nom intermediaire, correspond au nom inscrit dans le champ par le joueur (avant le jeu)

    public string nom { get => _nom; set => _nom = value; } //accesseur et mutateur du nom
    public int vie { get => _vie; set => _vie = value; } //accesseur et mutateur de la vie
    public int score { get => _score; set => _score = value; } //accesseur et mutateur du score
    public string nomIntermediaire { get => _nomIntermediaire; set => _nomIntermediaire = value; } //accesseur et mutateur du nom intermediaire


    /// <summary>
    /// Methode qui remplace les valeurs en cours par les valeurs initiales
    /// </summary>
    public void Initialiser()
    {
        if(_nomIntermediaire != "") _nom = _nomIntermediaire; //si le nom inter n'est pas vide, changer le nom selon le nom inter
        else _nom = _nomIni; //sinon, changer le nom pour le nom par defaut

        _nomIntermediaire = ""; //vider le nom inter, pour la prochaine fois!
        _vie = _vieIni;  //initialiser la valeur du nombre de vie
        _score = _scoreIni;  //initialiser le score
    }
}