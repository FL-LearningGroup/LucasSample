const random_jokes = [
  {
      id: 1,
      setup: 'What is the object oriented way to get wealthy ?',
      punchline: 'Inheritance',
  },
  {
    id: 2,
    setup: 'To understand what recursion is...',
    punchline: "You must first understand what recursion is",
  },
  {
    id: 3,
    setup: 'What do you call a factory that sells passable products?',
    punchline: 'A satisfactory',
  },
];

let random_joke_call_count = 0;

export default {
  'get /api/InitCard': function (req, res) {
    const responseObj = random_jokes[random_joke_call_count % random_jokes.length];
    random_joke_call_count += 1;
    setTimeout(() => {
      res.json(responseObj);
    }, 3000);
  },
};