using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList =
    {
        "bujuk", "interpelasi", "balistik", "pales", "satanologi", "safa", "gegadan", "molekul", "kwartir",
        "kelelap", "royak", "mondeling", "betonisasi", "setrika", "akidah", "seruru", "tona", "gaet", "pedapa", "peningset",
        "gudang", "sentosa", "klaustrum", "langse","remas","jidat", "delineasi","milimikron","celampak", "kucam","futurologi",
        "muzaki", "kalpataru","wegah","klerus", "kepar","uniform","degap", "tembel","peda", "lakonik", "komisaris", "ganas",
        "pecai", "kompor","mumifikasi","istazah","walakhir","ekon","maskulinitas", "lengang","selepe", "selter", "hanif","ibun",
        "tabal","tentu","tanker","siriasis", "sentigram","monokrom","ranjau", "keretek","kamrad","jaras","jaiz","hidrologi",
        "aspirator", "travesti","tahi","denasalisasi", "proposisi","sulalah","retromamal", "kobar","baitulmakdis","zarah",
        "deskriptif","mentis","harimau", "luli","klonus","glomus", "ulat", "sadai", "bakas", "nuklida","ambau","bengkudu",
        "umpil","hamun", "biseksual", "orak","iradat", "geblek", "cakalele", "vulgar", "mokal", "fenomenologi", "septum", "sewal",
        "tomang", "asonansi", "kafi", "cengek", "belanja", "laberang","vasal","kermanici", "badan","rakat","zair", "seri","cegat",
        "prometium","netralitas","luncai","mikrosefalia","pelembaya"
    };
    
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}