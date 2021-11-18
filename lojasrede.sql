-- Banco de dados: `lojasrede`
--

CREATE DATABASE `lojasrede`;

--
-- Estrutura da tabela `produto`
--

DROP TABLE IF EXISTS `lojasrede`.`produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NOME_PRODUTO` varchar(100) NOT NULL,
  `PRECO` double DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `lojasrede`.`produto` (`ID`, `NOME_PRODUTO`, `PRECO`) VALUES
(1, 'julao3k', 15),
(2, 'wgvb', 0),
(3, 'julao45k', 15);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

DROP TABLE IF EXISTS `lojasrede`.`usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `EMAIL` varchar(100) NOT NULL,
  `SENHA` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `lojasrede`.`usuario` (`ID`, `EMAIL`, `SENHA`) VALUES
(1, 'julio@gmail', 'teste'),
(2, 'julio@gmail', 'teste');

