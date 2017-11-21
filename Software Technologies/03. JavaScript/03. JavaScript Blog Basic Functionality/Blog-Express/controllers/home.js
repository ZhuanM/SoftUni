const Article = require("../models/Article");

module.exports = {
  index: (req, res) => {
      Article.find().then(articles => {
          res.render('index', { articles });
      });
  }
};