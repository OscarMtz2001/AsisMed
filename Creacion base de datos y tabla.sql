CREATE DATABASE asismed;

USE asismed;

CREATE TABLE `asismed`.`usuarios`
(`id` SMALLINT(3) NOT NULL AUTO_INCREMENT,
`usuario` VARCHAR(20) NOT NULL,
`contrasena` VARCHAR(25) NOT NULL,
`nombre` VARCHAR(50) NOT NULL,
`apellido_paterno` VARCHAR(25) NOT NULL,
`apellido_materno` VARCHAR(25) NOT NULL,
PRIMARY KEY (`id`));
