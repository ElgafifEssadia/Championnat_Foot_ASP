INSERT INTO Equipe (NomEq, AbreEq, Ville, Tel, Adresse, Logo) VALUES ('Association Sportive des FAR ', 'FAR', 'Rabat', '0632569253', 'Rue Jawhara', 'FAR.png'),
																	 ('Chabab Atlas Khenifra', 'CAK', 'Khenifra', '0625348215', 'Rue Sefrou ,Avenue Hassan II', 'CAK.png'),
																	 ('Chabab Rif Al Hceima', 'CRA', 'Al Hoceima', '0614507829', '85 Avenue Mohamed V', 'CRA.png')

INSERT INTO Joueur (CodeJou, Nom, Prenom, Poste, Nationalite) VALUES (1, 'Diakite', 'Lamina', 'Milieu', 'MAR'),
																	 (2, 'Majid', 'Aymane', 'Gardien', 'MAR'),
																	 (3, 'Mezgouri', 'Oussama', 'Milieu', 'MAR'),
																	 (4, 'Miftah', 'Faissal', 'Defenseur', 'MAR'),
																	 (5, 'Lengoualama', 'Johan', 'Attaquant', 'GAB'),
																     (6, 'Nahiri', 'Mohammed', 'Defenseur', 'MAR'),
																	 (7, 'Laba', 'Kodjo', 'Milieu', 'TGO'),
																	 (8, 'Nakach', 'Brahim', 'Milieu', 'MAR'),
																	 (9, 'Nicaise', 'Doa Guillaume', 'Attaquant', 'CIV'),
																	 (10, 'Djimrangar', 'Léger', 'Attaquant', 'TCD')

INSERT INTO Saison (CodeSai) VALUES ('2016-2017'),
									('2016-2020'),
									('2017-2018'),
									('2018-2019')

INSERT INTO Stade (NomStd, Capacite, Adresse, Ville, Peleuse, Largeur, Longueur, Photo) VALUES ('Complexe Sportif de Fes', 45000, 'Route Sfrou', 'Fes', 'Naturelle', 68, 105, 'StadeFes.jpg'),
																							   ('Complexe Sportif du Phosphate', 15000, 'av Omar elkhayyam', 'Khouribga', 'Naturelle', 68, 105, 'StadeKhouribga.jpg'),
																							   ('Complexe Sportif Moulay Abdallah', 68000, 'Av Hassan II ElMassira', 'Rabat', 'Naturelle', 67, 103, 'StadeRabat.jpg'),
																							   ('Grand stade de Casablanca', 120000, 'Rue Al Azrak Ahmed, 20250', 'Casablanca', 'Naturelle', 67, 103, 'StadeCasa.jpg'),
																							   ('Grand Stade de Marrakech', 45240, 'N°9, ouahat sidi Brahim', 'Marrakech', 'naturelle', 68, 105, 'StadeMarrakech.jpg'),
																							   ('Saniat Rmel', 35000, 'Avenue Avril', 'Tetouan', 'Naturelle', 68, 105, 'StadeTetouan.jpg'),
																							   ('Stade Adrar', 45480, 'Route de l aéroport international d Agadir', 'Agadir', 'Naturelle', 68, 103, 'StadeAgadir.jpg'),
																							   ('Stade Ben-Ahmed El-Abdi', 15000, 'Av AlMassira AlKhadra', 'El-jadida', 'Naturelle', 68, 105, 'StadeElJadida.png')

INSERT INTO Selection (codesai, nomeq, codejou, nummaillot) VALUES ('2017-2018', 'Association Sportive des FAR', 1, 1),
																   ('2016-2017', 'Chabab Atlas Khenifra', 2, 25),
																   ('2018-2019', 'Chabab Rif Al Hceima', 3, 28)

INSERT INTO Matchs (codeMatch, NomEqDom, NomEqVis, nomStd, DateMatch, Attendence, Temperature, Humidite, ButDom, ButVis, TypeMatch) VALUES (1, 'Association Sportive des FAR', 'Chabab Atlas Khenifra', 'Stade Ben-Ahmed El-Abdi','2017-09-09', 5000, 36, 50, 0, 0, ''),
																																			(2, 'Chabab Atlas Khenifra', 'Association Sportive des FAR', 'Saniat Rmel','2017-09-16', 5480, 36, 50, 2, 0, ''),
																																			(3, 'Chabab Rif Al Hceima', 'Chabab Atlas Khenifra', 'Complexe Sportif du Phosphate', '2017-09-24', 5480, 36, 50, 2, 0, ''),
																																			(4, 'Chabab Atlas Khenifra', 'Chabab Rif Al Hceima', 'Complexe Sportif de Fes','2017-09-29', 5480, 36, 50, 1, 1, '')

INSERT INTO Journee (NumJour, CodeSai, Date_Debut, Date_Fin, Detail) VALUES (1, '2017-2018', '2017-12-07', '2017-12-08', 'Bla Bla'),
																			(2, '2018-2019', '2017-10-14', '2017-10-15', 'Bla Bla'),
																			(3, '2016-2020', '2017-10-21', '2017-10-22', 'Bla Bla')

INSERT INTO Entraineur (codeent, nom, prenom, daten, nationnalite) VALUES (1, 'Fertout', 'Youssef', '1970-07-07', 'Maroc'),
																		  (2, 'Ammouta', 'Houcine', '1969-10-24', 'Maroc'),
																		  (3, 'Taleb', 'Abderrahim', '1963-09-10', 'Maroc'),
																		  (4, 'Garrido', 'Juan Carlos', '1996-03-29', 'Espagnol'),
																		  (5, 'Jaouani', 'Mounir', '1968-01-27', 'Maroc')

INSERT INTO Entrainer(nomeq, codesai, codeent) VALUES ('Association Sportive des FAR', '2017-2018', 1),
													   ('Chabab Atlas Khenifra', '2017-2018', 2),
													   ('Chabab Rif Al Hceima', '2017-2018', 3)

INSERT INTO Buts (codematch, codejou, minute) VALUES
														(1, 5, 45),
														(2, 10, 12),
														(3, 9, 90),
														(4, 7, 56)

INSERT INTO Arbitre (codearb, nom, prenom, daten, nationalite) VALUES
																	(1, 'El achiri', 'Abdellah', '1967-03-25', 'maroc'),
																	(2, 'Belqola', 'Said', '1956-08-30', 'maroc'),
																	(3, 'El arjoun', 'Abderrahim', '1963-07-19', 'maroc'),
																	(4, 'Guezzaz', 'Mohamed', '1962-10-01', 'maroc')

INSERT INTO Arbitrage (codearb, codematch, post) VALUES
														(1, 1, 'arbitre Assisstant'),
														(2, 2, 'Arbitre remplacant'),
														(3, 3, 'arbitre de Surface'),
														(4, 4, 'arbitre centrale')

INSERT INTO Participer (codematch, codejou) VALUES (2, 2),
												   (3, 4),
												   (4, 5)

INSERT INTO Remplacement (codematch, codejouin, codejouout, minute) VALUES  (1, 4, 10, 30),
																			(4, 2, 9, 70),
																			(3, 9, 8, 60),
																			(2, 10, 4, 20)
													   
																   