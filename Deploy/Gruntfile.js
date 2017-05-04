module.exports = function (grunt) {
  grunt.loadNpmTasks('grunt-ssh-deploy');

  grunt.initConfig({
    // do not store credentials in the git repo, store them separately and read from a secret file
    secret: grunt.file.readJSON('secret.json'),
    environments: {
      options: {
        host: '<%= secret.production.host %>',
        username: '<%= secret.production.username %>',
        password: '<%= secret.production.password %>',
        port: '<%= secret.production.port %>',
        releases_to_keep: '1',
        current_symlink: 'MYPark',
        deploy_path: '/home/myob'
      },
      full: {
        options: {
          local_path: '../MYPark/bin/Release/PublishOutput'
        }
      },
      patch: {
        options: {
          local_path: '../MYPark/bin/Release/PublishOutput/MYPark.dll'
        }
      }
    }
  });
  
};
