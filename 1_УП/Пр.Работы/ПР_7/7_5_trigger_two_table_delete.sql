SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER ��������_������� 
   ON  �������
   AFTER DELETE
AS 
BEGIN

	SET NOCOUNT ON;
	DELETE ������� FROM deleted
	WHERE deleted.[����������]=�������.[����������] DELETE ��������
	FROM deleted
	WHERE deleted.[�����������]=��������.[�����������]

END
GO
