//
// This is only a SKELETON file for the 'Protein Translation' exercise. It's been provided as a
// convenience to get you started writing code faster.
//
// This is only a SKELETON file for the 'Protein Translation' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const translate = sequence => {
  // Codone to Protein codes
  const CODES = {
    AUG: "Methionine",
    UUU: "Phenylalanine",
    UUC: "Phenylalanine",
    UUA: "Leucine",
    UUG: "Leucine",
    UCU: "Serine",
    UCC: "Serine",
    UCA: "Serine",
    UCG: "Serine",
    UAU: "Tyrosine",
    UAC: "Tyrosine",
    UGU: "Cysteine",
    UGC: "Cysteine",
    UGG: "Tryptophan",
    UAA: "STOP",
    UAG: "STOP",
    UGA: "STOP"
  };

  // Return immediately if no sequence given to process
  if (!sequence) {
    return [];
  }

  let sequenceSplit = [];

  // Split sequence into 3 char codes
  for (let i = 0; i < sequence.length; i += 3) {
    sequenceSplit.push(sequence.substring(i, i + 3));
  }
  // convert codon value to protein name
  let proteins = [];
  for (let code in sequenceSplit) {
    let codeValue = sequenceSplit[code];
    if (!(codeValue in CODES)) {
      throw new Error("Invalid codon");
    }

    codeValue = CODES[codeValue];
    if (codeValue == "STOP") break;
    else proteins.push(codeValue);
  }

  return proteins;
};
