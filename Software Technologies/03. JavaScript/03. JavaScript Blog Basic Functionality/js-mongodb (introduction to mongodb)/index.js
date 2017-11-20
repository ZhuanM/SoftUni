const mongoose = require('mongoose');
mongoose.connect('mongodb://localhost/blog');

let db = mongoose.connection;

db.on('error',
 console.error.bind(console, 'connection error:'));

db.once('open', function() {
  // we're connected!
  console.log("connected to MongoDB");
});

var articleSchema = mongoose.Schema({
    author: String,
	title: String,
	content: String,
});
var Article = mongoose.model('articles', articleSchema);

let newArticle = new Article({
	author: "Nakov",
	title: "New Article",
	content: "New articles content comes here..."
});
newArticle.save(function(err, savedObj) {
	if (err)
		console.log("Insert failed.");
	else
		console.log("New article created." + savedObj);
	
	Article.find(function (err, articles) {
	 if (err) return 
		console.error(err);
	console.log(articles);
	});
});