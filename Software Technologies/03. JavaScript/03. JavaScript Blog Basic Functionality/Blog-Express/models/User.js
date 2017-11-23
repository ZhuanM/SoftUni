const mongoose = require("mongoose");
const encryption = require("./../utilities/encryption");

let userSchema = mongoose.Schema({
    email: {type: String, required: true, unique: true},
    passwordHash: {type: String, required: true},
    fullName: {type: String, required: true},
    articles: {type: [mongoose.Schema.ObjectId], default:[]},
    salt: {type: String, required: true}
});

userSchema.method({
   authenticate: function (password) {
       let inputPasswdHash = encryption.hashPassword(password, this.salt)
       return inputPasswdHash == this.passwordHash;
   } 
});

const User = mongoose.model('User', userSchema);

module.exports = User;