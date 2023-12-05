package main

import (
	"bufio"
	"fmt"
	"os"
	"slices"
	"strings"
	"unicode"
)

func main() {
	/*
		1 filter
		2 to_small
		3 sort
		4 compare
	*/
	reader := bufio.NewReader(os.Stdin)
	s, _ := reader.ReadString('\n')
	s1, _ := reader.ReadString('\n')
	// s := "«Tom Marvolo Riddle»"
	// s1 := "«I am Lord Voldemort!»"
	s = sort_string_by_ASCII(strings.ToLower(filter_letters(s)))
	s1 = sort_string_by_ASCII(strings.ToLower(filter_letters(s1)))
	if s == s1 {
		fmt.Println("YES")
	} else {
		fmt.Println("NO")
	}
}

func filter_letters(input string) string {
	var sb strings.Builder
	for _, c := range input {
		if unicode.IsLetter(c) {
			sb.WriteRune(c)
		}
	}
	return sb.String()
}

func sort_string_by_ASCII(input string) string {
	chars := []rune(input)
	slices.Sort(chars)
	result := string(chars)
	return result
}
