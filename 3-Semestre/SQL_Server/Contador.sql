create procedure contagem (@limite int, @tipo int)
as begin
   declare @i int

   if @tipo = 1 begin
      set @i = @limite
      while @i >= 1 begin
         select valor = @i
	     set @i = @i - 1
      end
   end

   if @tipo = 2 begin
      set @i = 1
      while @i <= @limite begin
        select valor = @i
	    set @i = @i + 1
      end
   end
end

-----------------------------------------------------

exec contagem 10, 1
