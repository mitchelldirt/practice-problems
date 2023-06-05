const PiePeople = [
  { name: "Joe", num: 9 },
  { name: "Cami", num: 3 },
  { name: "Cassidy", num: 4 },
];

function howManyPies(peopleSlices: typeof PiePeople, slicesPerPie: number) {
  let totalSlicesPerPeople = 0;

  // Add up all the slices per person
  peopleSlices.forEach((person) => (totalSlicesPerPeople += person.num));

  // Divide the total slices per person by the slices per pie and round up
  return Math.ceil(totalSlicesPerPeople / slicesPerPie);
}

console.log(howManyPies(PiePeople, 8));
