using CodeAlongOns;

// futurum
// conditionnal
// passé composé

// Parl-er
// je parl-erai
// je parl-erais
// j'ai parl-é

// fini-r
// fini-rai
// fini-rais
// fini

// Vand-re
// vend-rai
// vend-rais
// vend-u




string tenseChosen = Utilities.GetVerbTense();
string enteredWord = Utilities.GetVerb();
string verbKind = Utilities.GetVerbKind(enteredWord);
string finalResult = Utilities.GetFinalResult(tenseChosen, enteredWord);
Utilities.OutputFinalResult(finalResult, verbKind);
