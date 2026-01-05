CREATE DATABASE IF NOT EXISTS moneyflow
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

USE moneyflow;

CREATE TABLE IF NOT EXISTS financial_records (
    id 					INT AUTO_INCREMENT 	PRIMARY KEY,
    transaction_date 	DATE 				NOT NULL,
    history 			VARCHAR(255),
    description 		VARCHAR(255) 		NOT NULL,
    amount 				DECIMAL(10,2) 		NOT NULL,
    transaction_type 	INT NOT NULL,
    created_at 			TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
SELECT * FROM financial_records;