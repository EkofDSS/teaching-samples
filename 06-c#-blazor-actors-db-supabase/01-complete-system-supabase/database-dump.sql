CREATE OR REPLACE FUNCTION get_actors_with_country() RETURNS TABLE (
    id int8,
    last_name varchar,
    first_name varchar,
    country_id int8,
    country_name varchar,
    country_code varchar,
    date_of_birth date
) AS $$
BEGIN
    RETURN QUERY
    SELECT a.id, a.last_name, a.first_name, a.country_id, c.name as country_name, c.code as country_code, a.date_of_birth
    FROM public."Actor" a
    JOIN public."Country" c ON a.country_id = c.id;
END;
$$ LANGUAGE plpgsql;
