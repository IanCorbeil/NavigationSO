using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Classe pour afficher le meilleur joueur et son meilleur niveau
/// </summary>
public class GestFin : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _champMeilleur;
    [SerializeField] private InfosJoueur _iJoueur;
    [SerializeField] private InfosNavig _iNavig;


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        string nomVarMeilleurNiveau = "meilleurNiveau";
        string nomVarMeilleurJoueur = "meilleurJoueur";
        int meilleurNiveau =  PlayerPrefs.GetInt(nomVarMeilleurNiveau, 0);

        if(_iNavig.niveau>meilleurNiveau)
        {
            PlayerPrefs.SetString(nomVarMeilleurJoueur, _iJoueur.nom);
            PlayerPrefs.SetInt(nomVarMeilleurNiveau, _iNavig.niveau);
            meilleurNiveau = _iNavig.niveau;
        }

        string meilleurJoueur = PlayerPrefs.GetString(nomVarMeilleurJoueur, "anonyme");
        _champMeilleur.text = meilleurJoueur.ToUpper()+": NIVEAU "+meilleurNiveau;
    }

}
