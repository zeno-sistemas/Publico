var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res, next) {
  global.db.findAll((e, docs) => {
      res.render('index', { title: 'Lista todos', docs: docs });
  });
});

router.get('/novo', function(req, res, next) {
  res.render('novo', { title: 'Novo Cadastro', doc: {"nome":"","idade":""}, action: '/novo' });
});

router.post('/novo', function(req, res) {
  var nome = req.body.nome;
  var idade = parseInt(req.body.idade);
  global.db.insert({nome, idade}, (err, result) => {
        if(err) { return console.log(err); }
        res.redirect('/');
    });
});

router.get('/editar/:id', function(req, res, next) {
  var id = req.params.id;
  global.db.findOne(id, (e, docs) => {
      if(e) { return console.log(e); }
      res.render('novo', { title: 'Edição de Cliente', doc: docs[0], action: '/editar/' + docs[0]._id });
    });
});

router.post('/editar/:id', function(req, res) {
  var id = req.params.id;
  var nome = req.body.nome;
  var idade = parseInt(req.body.idade);
  console.log("gravando!");
  global.db.update(id, {nome, idade}, (e, result) => {
        if(e) { return console.log(e); }
        res.redirect('/');
    });
});

router.get('/delete/:id', function(req, res) {
  var id = req.params.id;
  global.db.deleteOne(id, (e, r) => {
        if(e) { return console.log(e); }
        res.redirect('/');
      });
});

module.exports = router;


