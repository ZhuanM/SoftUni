const crypto = require('crypto');

module.exports = ({
  generateSalt: function() {
      let salt = crypto.randomBytes(128).toString('base64');
      return salt;
  },

    hashPassword: (password, salt) => {
        let passwdHash = crypto.createHmac('sha256', salt).update(password).digest("hex");
        return passwdHash;
    }
});



