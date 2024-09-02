BEGIN TRANSACTION;
GO

ALTER TABLE [Products] ADD [DiscountPercentage] decimal(18,2) NOT NULL DEFAULT 0.0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240902185026_Add-DiscountPercentage-Column', N'6.0.0');
GO

COMMIT;
GO

