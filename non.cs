// Create a list of test objects
List<Person> testObjects = new List<Person>();
testObjects.Add(new Person { Name = "Alice", Age = 25 });
testObjects.Add(new Person { Name = "Bob", Age = 30 });

// Create a repository instance
var repo = new Repository<Person>();

// Insert the test objects into the repository
repo.Insert(testObjects);
