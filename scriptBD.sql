CREATE DATABASE basedados_pacientes;
USE basedados_pacientes;

CREATE TABLE `endereco` (
    `id_endereco` INT(11) AUTO_INCREMENT,
    `logradouro` VARCHAR(45) DEFAULT NULL,
    `numero` INT(11) DEFAULT NULL,
    `complemento` VARCHAR(45) DEFAULT NULL,
    `bairro` VARCHAR(45) DEFAULT NULL,
    `municipio` VARCHAR(45) DEFAULT NULL,
    `uf` VARCHAR(2) DEFAULT NULL,
    `cep` VARCHAR(10) DEFAULT NULL,
    PRIMARY KEY (`id_endereco`)
);

CREATE TABLE `paciente` (
    `id_paciente` INT(11) AUTO_INCREMENT,
    `nome` VARCHAR(45) NOT NULL,
    `dt_nasc` VARCHAR(10) NOT NULL,
    `sexo` VARCHAR(1) DEFAULT NULL,
    `cpf` VARCHAR(17) NOT NULL,
    `celular` VARCHAR(17) DEFAULT NULL,
    `email` VARCHAR(45) DEFAULT NULL,
    `id_endereco` INT(11) NOT NULL,
    PRIMARY KEY (`id_paciente`),
    KEY `id_endereco` (`id_endereco`),
    CONSTRAINT `paciente_ibfk` FOREIGN KEY (`id_endereco`) REFERENCES `endereco` (`id_endereco`) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE `login` (
    `id` BIGINT(20) AUTO_INCREMENT,
    `usuario` VARCHAR(20) NOT NULL,
    `senha` VARCHAR(10) NOT NULL,
    PRIMARY KEY (`id`)
);

-- Corrección en la sentencia INSERT
INSERT INTO login (usuario, senha) VALUES ("admin", "admin");
